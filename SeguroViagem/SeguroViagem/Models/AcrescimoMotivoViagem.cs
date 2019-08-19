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
        public int SegId { get; set; }

        public MotivoViagemEnum MotivoViagem { get; set; }

        public double AcrescimoMotivo { get; set; }

        [NotMapped]
        public virtual Seguradora Seguradora { get; set; } // Relação com a entidade Seguradora que é representado pelo SegId.
    }
}