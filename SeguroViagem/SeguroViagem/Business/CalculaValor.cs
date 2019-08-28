using SeguroViagem.DAO;
using SeguroViagem.DAO.Acréscimos;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Business
{
    public class CalculaValor
    {
        
        public List<Seguradora>  CalculaValorCotacao(int idCotacao)
        {

            var cotacao = new CotacaoDAO().BuscarPorId(idCotacao); // Busca no banco pelo id da cotação
            if (cotacao == null) // Caso não tenha cotação, ele retorna a lista vazia de seguradoras.
            {
                return new List<Seguradora>();
            }

            var listaSeguradoras = new SeguradoraDAO().Lista().ToList();            

            foreach (var seguradora in listaSeguradoras)
            {

                var acrescimoTipoViagem = new AcrescimoTipoViagemDAO().ObterPorTipoViagem(seguradora.SegId, cotacao.TipoViagem); // passando como parâmetro os valores da tabela seguradora.SegId e tabela cotacao.TipoViagem

                double acrescimo1 = 0, acrescimo2 = 0, acrescimo3 = 0;

                var ValorDias = seguradora.ValorPorDia * cotacao.QtdeDias; // Valor por dia * qntide de dias que o usuário vai ficar
                var ValorPessoa = seguradora.ValorPorPessoa * cotacao.QtdeViajantes; // Valor por pessoa * qntde de Viajantes
                var Comissao = (seguradora.Comissao / 100) + 1;
                var ValorFinal = ValorDias + ValorPessoa;

                if (acrescimoTipoViagem != null)
                {
                    acrescimo1 = ValorFinal * ((acrescimoTipoViagem.AcrescimoViagem/100) + 1);  // 
                }


                var acrescimoMeioTransporte = new AcrescimoMeioTransporteDAO().ObterPorMeioTransporte(seguradora.SegId, cotacao.MeioTransporte);

                if (acrescimoMeioTransporte != null)
                {
                    acrescimo2 = ValorFinal * (( acrescimoMeioTransporte.AcrescimoTransporte / 100 ) + 1);
                }

                var acrescimoMotivoViagem = new AcrescimoMotivoViagemDAO().OberPorMotivoViagem(seguradora.SegId, cotacao.MotivoViagem);

                if (acrescimoMotivoViagem != null)
                {
                    acrescimo3 = ValorFinal * (( acrescimoMotivoViagem.AcrescimoMotivo / 100 ) + 1);
                }

                seguradora.Valor = (acrescimo1 + acrescimo2 + acrescimo3) * Comissao;
            }

            return listaSeguradoras;
        }
    }
}