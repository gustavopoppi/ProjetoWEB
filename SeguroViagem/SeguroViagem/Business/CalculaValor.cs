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

                double acrescimo = 0;

                if (acrescimoTipoViagem != null)
                {
                    //acrescimo = seguradora.ValorPorDia * acrescimoTipoViagem.AcrescimoViagem ;  // fazer conversão inteiro para % 
                }


                var acrescimoMeioTransporte = new AcrescimoViagemDAO().ObterPorMeioTransporte(seguradora.SegId, cotacao.MeioTransporte);

                if (acrescimoMeioTransporte != null)
                {
                   //acrescimo += seguradora.ValorPorDia * acrescimoMeioTransporte.AcrescimoTransporte;
                }

                var acrescimoMotivoViagem = new AcrescimoViagemDAO().OberPorMotivoViagem(seguradora.SegId, cotacao.MotivoViagem);

                if (acrescimoMotivoViagem == null)
                {
                     //acrescimo = 0;
                }

                //seguradora.Valor = acrescimo
            }

            return listaSeguradoras;
        }
    }
}