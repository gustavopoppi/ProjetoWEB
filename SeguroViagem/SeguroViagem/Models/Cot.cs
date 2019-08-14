using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class Cot
    {
        public int CotId { get; set; }
        public string TipoViagem { get; set; }
        public string[] TipoViagens = new[] { "Nacional", "Internacional" };
        public string MeioTransporte { get; set; }
        public string MotivoViagem { get; set; }
        public string QtdeDias { get; set; }
        //public string Origem { get; set; }
        //public string Destino { get; set; }
        public string QtdeViajantes { get; set; }

        public int DestinoId { get; set; }
        public int OrigemId { get; set; }
        public Estados Estados { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> EstadoLista { get; set; }
    }
}