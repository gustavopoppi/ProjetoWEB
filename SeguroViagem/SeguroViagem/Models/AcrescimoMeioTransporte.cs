using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class AcrescimoMeioTransporte
    {
        [Key]
        public int TransporteId { get; set; }
        public int SegId { get; set; }

        public MeioTransporteEnum MeioTransporte {get; set;}

        public double AcrescimoTransporte { get; set;}

        [NotMapped]
        public virtual Seguradora Seguradora { get; set; } // Relação com a entidade Seguradora que é representado pelo SegId.
    }
}