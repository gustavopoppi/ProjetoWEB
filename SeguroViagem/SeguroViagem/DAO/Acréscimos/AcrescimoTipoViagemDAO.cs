using Microsoft.EntityFrameworkCore;
using SeguroViagem.Models;
using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO
{
    public class AcrescimoTipoViagemDAO
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();

        public void Adicionar()
        {

        }
        public IList<AcrescimoTipoViagem> Lista()
        {
            return db.AcrescimosTipoViagem.Include(c=>c.Seguradora).ToList();
            //return db.AcrescimosTipoViagem.Include(c=>c.Nome).ToList();
        }
        public void Atualizar(AcrescimoTipoViagem acrescimoTipoViagem)
        {
            db.AcrescimosTipoViagem.Update(acrescimoTipoViagem);
            db.SaveChanges();
        }
        public void Remover(AcrescimoTipoViagem acrescimoTipoViagem)
        {
            int id = 0;
            db.AcrescimosTipoViagem.Where(f => f.TipoId == id);
            db.AcrescimosTipoViagem.Remove(acrescimoTipoViagem);
            db.SaveChanges();
        }
        public AcrescimoTipoViagem BuscaPorId(int id)
        {
            return db.AcrescimosTipoViagem.Include(c=>c.Seguradora).Where(f => f.TipoId == id).FirstOrDefault();
        }


        public AcrescimoTipoViagem ObterPorTipoViagem(int segId, TipoViagemEnum tipoViagem)
        {
            // return nome da minha tabela, e pegou o campo SedId e seto para o valor do parâmetro passado, isso acontece para o TipoViagem também.
            return db.AcrescimosTipoViagem.Where(x => x.SegId == segId && x.TipoViagem == tipoViagem).FirstOrDefault();
        }
    }

}