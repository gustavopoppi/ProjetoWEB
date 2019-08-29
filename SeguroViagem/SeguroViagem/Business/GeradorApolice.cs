using SeguroViagem.DAO;
using SeguroViagem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Business
{
    public class GeradorApolice
    {
        public ImpressaoViewModel GerarApolice(PagamentoViewModel pagamento)
        {
            var impressaoViewModel = new ImpressaoViewModel
            {
                PagamentoViewModel = pagamento,
                DadosViajante = new DadosViajanteDAO().BuscarPorId(pagamento.ViajanteId),
                Cotacao = new CotacaoDAO().BuscarPorId(pagamento.CotId),
                Seguradora = new SeguradoraDAO().BuscarPorId(pagamento.SegId)
            };
            // calcular o valor da seguradora selecionada, passando tanto a selecionada quanto a cotação
            new CalculaValor().CalculaValorSeguradora(impressaoViewModel.Seguradora, impressaoViewModel.Cotacao);

            return impressaoViewModel;
        }

            
    }
}