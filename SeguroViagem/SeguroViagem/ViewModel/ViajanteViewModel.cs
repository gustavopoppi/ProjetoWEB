using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguroViagem.ViewModel
{
    public class ViajanteViewModel
    {

        //public ViajanteViewModel()
        //{
        //    Pagamento = new PagamentoViewModel();
        //}

        public int SegId { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Sobrenome { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string CPF { get; set; }

        [DisplayName("Data de Nascimento")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime? DataNascimento { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Sexo { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int? CEP { get; set; }

        [DisplayName("Endereço")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int? Numero { get; set; }


        public string Complemento { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Email { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int? Contato1 { get; set; }


        public int? Contato2 { get; set; }

        [DisplayName("Profissão")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string Profissao { get; set; }

        //public PagamentoViewModel Pagamento { get; set; }



        public string Bandeira { get; set; }

        [DisplayName("Nome Cartão")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public string NomeCartao { get; set; }

        [DisplayName("Número do Cartão")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int NumeroCartao { get; set; }

        [DisplayName("Cód. Seg.")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int CodSeguranca { get; set; }

        [DisplayName("Mês")]
        //[Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime ValidadeMes { get; set; }

        [DisplayName("Ano")]
       // [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime ValidadeAno { get; set; }


        //[Required(ErrorMessage = "Campo Obrigatório")]
        public int Parcelas { get; set; }

    }
    public enum Sexo
    {
        Feminino,
        Masculino,
        Outros
    }
}