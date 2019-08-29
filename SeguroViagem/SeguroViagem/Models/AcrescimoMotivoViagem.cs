using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class AcrescimoMotivoViagem
    {
        [Key]
        public int MotivoId { get; set; }


        [Display(Name = "Seg Id")]
        public int SegId { get; set; }


        [Display(Name = "Motivo Viagem")]
        public MotivoViagemEnum MotivoViagem { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Acréscimo Motivo Viagem")]
        [Range(1, 100, ErrorMessage = "Acréscimo Inválido")]
        public double AcrescimoMotivo { get; set; }

        [NotMapped]
        public virtual Seguradora Seguradora { get; set; } // Relação com a entidade Seguradora que é representado pelo SegId.
    }
}