using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class DadosViajante
    {
        [Key]
        public int ViajanteId { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Sobrenome { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(15, MinimumLength = 14, ErrorMessage = "CPF Inválido")]
        public string CPF { get; set; }

        [DisplayName("Data de Nascimento")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime? DataNascimento { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Sexo { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        //[StringLength(10, MinimumLength = 7, ErrorMessage = "CEP Inválido")]
        public int? CEP { get; set; }

        [DisplayName("Endereço")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Endereco { get; set; }

        [DisplayName("Número")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public int? Numero { get; set; }


        public string Complemento { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Bairro { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Estado { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Cidade { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail em formato inválido.")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Campo Obrigatório")]
        //[StringLength(10, MinimumLength = 7, ErrorMessage = "Contato Inválido")]
        public int? Contato1 { get; set; }

        
        public int? Contato2 { get; set; }

        [DisplayName("Profissão")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Profissao { get; set; }


    }
}