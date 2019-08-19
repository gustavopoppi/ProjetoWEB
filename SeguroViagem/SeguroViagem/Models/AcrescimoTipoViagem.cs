using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class AcrescimoTipoViagem
    {
        public int SegId { get; set; }

        public TipoViagemEnum TipoViagem { get; set; }

        public double Acrescimo { get; set; }

        [NotMapped]
        public virtual Seguradora Seguradora { get; set; } // Relação com a entidade Seguradora que é representado pelo SegId.

    }
}