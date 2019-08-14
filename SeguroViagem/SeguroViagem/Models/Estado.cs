using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Estado
    {
        [Key]
        public int EstadoId { get; set; }
        [Required]
        public string Estados { get; set; }

        public IList<Cotacao> Cotacao { get; set; }
    }
}

