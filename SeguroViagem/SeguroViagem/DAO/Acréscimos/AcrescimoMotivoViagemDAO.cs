using SeguroViagem.Models;
using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;

namespace SeguroViagem.DAO.Acréscimos
{
    public class AcrescimoMotivoViagemDAO
    {
        SeguroViagemContexto db = new SeguroViagemContexto();

        public void Adicionar()
        {

        }
        public IList<AcrescimoMotivoViagem> Lista()
        {
            return db.AcrescimosMotivoViagem.Include(c=>c.Seguradora).ToList();
        }
        public void Atualizar(AcrescimoMotivoViagem acrescimoMotivoViagem)
        {
            db.AcrescimosMotivoViagem.Update(acrescimoMotivoViagem);
            db.SaveChanges();
        }
        public void Remover(AcrescimoMotivoViagem acrescimoMotivoViagem)
        {
            int id = 0;
            db.AcrescimosMotivoViagem.Where(f => f.MotivoId == id);
            db.AcrescimosMotivoViagem.Remove(acrescimoMotivoViagem);
            db.SaveChanges();
        }
        public AcrescimoMotivoViagem BuscaPorId(int id)
        {
            return db.AcrescimosMotivoViagem.Include(c=>c.Seguradora).Where(f => f.MotivoId == id).FirstOrDefault();
        }

        public AcrescimoMotivoViagem OberPorMotivoViagem(int segId, MotivoViagemEnum motivoViagem)
        {
            return db.AcrescimosMotivoViagem.Where(x => x.SegId == segId && x.MotivoViagem == motivoViagem).FirstOrDefault();
        }
    }
}