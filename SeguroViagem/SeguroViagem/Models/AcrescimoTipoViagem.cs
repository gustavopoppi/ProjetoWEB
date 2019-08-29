using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class AcrescimoTipoViagem
    {
        [Key]
        public int TipoId { get; set; }


        [Display(Name = "Seg Id")]
        public int SegId { get; set; }

        
        [Display(Name = "Tipo da Viagem")]
        public TipoViagemEnum TipoViagem { get; set; } //  Nacional = 1, Internacional = 2

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Acréscimo Tipo Viagem")]
        [Range(1, 100, ErrorMessage = "Acréscimo Inválido")]
        public double AcrescimoViagem { get; set; }

        [NotMapped]
        public virtual Seguradora Seguradora { get; set; } // Relação com a entidade Seguradora que é representado pelo SegId.

        

    }
}