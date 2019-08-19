using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Business
{
    public class CalculaValor
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();
        public List<Seguradora> CalculaValorCotacao(Cotacao cotacao)
        {

            var listaSeguradoras = db.Seguradoras.ToList();
            
            foreach (var seguradora in listaSeguradoras)
            {
                /*seguradora.Valor =*/ // regra para criar o valor
                
                var acrescimoTipoViagem = new AcrescimoViagemDAO().ObterPorTipoViagem(seguradora.SegId, cotacao.TipoViagem); // passando como parâmetro os valores da tabela seguradora.SegId e tabela cotacao.TipoViagem

                if (acrescimoTipoViagem == null)
                {
                    var acrescimo = 0;
                }

                var acrescimoMeioTransporte = new AcrescimoViagemDAO().ObterPorMeioTransporte(seguradora.SegId, cotacao.MeioTransporte);

                if (acrescimoMeioTransporte == null)
                {
                    var acrescimo = 0;
                }

                var acrescimoMotivoViagem = new AcrescimoViagemDAO().OberPorMotivoViagem(seguradora.SegId, cotacao.MotivoViagem);

                if (acrescimoMotivoViagem == null)
                {
                    var acrescimo = 0;
                }

                //seguradora.Valor = acrescimoViagem
            }

            return listaSeguradoras;
        }
    }
}