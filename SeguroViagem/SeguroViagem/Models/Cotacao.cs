using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Models
{
    public class Cotacao
    {
        [Key]
        public int CotId { get; set; }

        public string TipoViagem { get; set; }

        public string[] TipoViagens = new[] { "Nacional", "Internacional" };
        [Required]
        public string MeioTransporte { get; set; }
        public string[] MeiosDeTransportes = new[] { "Aéreo", "Marítimo", "Ambos" };
        [Required]
        public string MotivoViagem { get; set; }
        public string[] MotivoViagens = new[] { "Lazer", "Estudo", "Negócios" };

        [Required]
        public DateTime Ida { get; set; }
        [Required]
        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Volta { get; set; }

        [Required]
        public int QtdeDias { get; set; }

        [Required]
        public string QtdeViajantes { get; set; }

        public int DestinoId { get; set; }

        public int OrigemId { get; set; }

        public virtual Estado Estados { get; set; }

        //[NotMapped]
        //public virtual IEnumerable<Estado> Estados { get; set; }


        [NotMapped]
        public IEnumerable<SelectListItem> EstadoLista { get; set; }

        public double Duracao(DateTime Ida, DateTime Volta)
        {
            TimeSpan DiasTotaisDeViagem = Ida.Subtract(Volta);
            return DiasTotaisDeViagem.TotalDays;
        }

        [NotMapped]
        public IEnumerable<SelectListItem> TypeList
        {
            get
            {
                return new List<SelectListItem>
                {
                    new SelectListItem { Text = "1", Value = "1"},
                    new SelectListItem { Text = "2", Value = "2"},
                    new SelectListItem { Text = "3", Value = "3"},
                    new SelectListItem { Text = "4", Value = "4"},
                    new SelectListItem { Text = "5", Value = "5"},
                    new SelectListItem { Text = "6", Value = "6"},
                    new SelectListItem { Text = "7", Value = "7"},
                    new SelectListItem { Text = "8", Value = "8"},
                    new SelectListItem { Text = "9", Value = "9"},
                    new SelectListItem { Text = "10", Value = "10"}
                };
            }
        }
    }
}