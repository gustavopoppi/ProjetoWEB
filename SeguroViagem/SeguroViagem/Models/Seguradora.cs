using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class Seguradora
    {

        [Key]
        public int SegId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Nome Seguradora")]
        public string NomeSeg { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Comissão")]
        public int Comissao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Extravio Bagagem")]
        public Nullable<decimal> ExtBagagem { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Morte Acidental")]
        public Nullable<decimal> MorteAcid { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Translado de Corpo")]
        public Nullable<decimal> TransCorpo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Invalidez Permanente")]
        public Nullable<decimal> InvalidezPerm { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Despesas Farmácia")]
        public Nullable<decimal> DespesasFarmacia { get; set; }
    }
}