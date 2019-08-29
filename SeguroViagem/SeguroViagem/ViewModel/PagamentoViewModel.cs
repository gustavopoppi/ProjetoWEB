using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.ViewModel
{
    public class PagamentoViewModel
    {
        //public double Valor { get; set; }
        public int CotId { get; set; }
        public int SegId { get; set; }
        
        public int ViajanteId { get; set; }

        public string Bandeira { get; set; }

        [DisplayName("Nome Cartão")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCartao { get; set; }

        [DisplayName("Número do Cartão")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.CreditCard, ErrorMessage = "Valor do cartão Inválido")]
        public int? NumeroCartao { get; set; }

        [DisplayName("Cód. Seg.")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(3, 4, ErrorMessage = "Código Inválido")]
        public int? CodSeguranca { get; set; }

        [DisplayName("Mês")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(2, 2, ErrorMessage = "Mês Inválido")]
        public int? ValidadeMes { get; set; }

        [DisplayName("Ano")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(4,4,ErrorMessage = "Ano Inválido")]
        public int? ValidadeAno { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public int Parcelas { get; set; }
    }

}