using SeguroViagem.Models;
using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO
{
    public class AcrescimoViagemDAO
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();

        //Criação da minha função "ObterPorSeguradora" e depois eu puxo no meu "CalculaValor".

        public AcrescimoTipoViagem ObterPorTipoViagem(int segId, TipoViagemEnum tipoViagem)
        {
            // return nome da minha tabela, e pegou o campo SedId e seto para o valor do parâmetro passado, isso acontece para o TipoViagem também.
            return db.AcrescimosTipoViagem.Where(x => x.SegId == segId && x.TipoViagem == tipoViagem).FirstOrDefault();
        }

        public AcrescimoMeioTransporte ObterPorMeioTransporte(int segId, MeioTransporteEnum meioTransporte)
        {
            return db.AcrescimosMeioTransporte.Where(x => x.SegId == segId && x.MeioTransporte == meioTransporte).FirstOrDefault();
        }

        public AcrescimoMotivoViagem OberPorMotivoViagem(int segId, MotivoViagemEnum motivoViagem)
        {
            return db.AcrescimosMotivoViagem.Where(x => x.SegId == segId && x.MotivoViagem == motivoViagem).FirstOrDefault();
        }

        
    }
}