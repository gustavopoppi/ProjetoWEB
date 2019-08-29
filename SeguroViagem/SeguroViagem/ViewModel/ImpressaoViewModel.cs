using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.ViewModel
{
    public class ImpressaoViewModel
    {
        public DadosViajante DadosViajante { get; set; }

        public PagamentoViewModel PagamentoViewModel { get; set; }

        public Seguradora Seguradora { get; set; }

        public Cotacao Cotacao { get; set; }
    }
}