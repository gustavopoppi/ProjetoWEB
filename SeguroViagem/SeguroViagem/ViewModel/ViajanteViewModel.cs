using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguroViagem.ViewModel
{
    public class ViajanteViewModel
    {
        public int SegId { get; set; }
        [Required]
        public string Nome {get;set;}
        public string Sobrenome { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public int CEP { get; set; }
        public string Endereço { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public int Contato1 { get; set; }
        public int Contato2 { get; set; }
        public string Profissao { get; set; }
    }
}