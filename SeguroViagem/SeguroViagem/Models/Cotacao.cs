﻿using SeguroViagem.Models.Enum;
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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CotId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public TipoViagemEnum TipoViagem { get; set; } // salvar no banco como 1 - nacional, 2 - internacional


        [Required(ErrorMessage = "Campo Obrigatório")]
        public string MeioTransporte { get; set; }
        public string[] MeiosDeTransportes = new[] { "Aéreo", "Marítimo", "Ambos" };

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string MotivoViagem { get; set; }
        public string[] MotivoViagens = new[] { "Lazer", "Estudo", "Negócios" };

        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Ida { get; set; }


        //[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public DateTime Volta { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int QtdeDias { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string QtdeViajantes { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int DestinoId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public int OrigemId { get; set; }

        [NotMapped]
        public virtual Estado Origem { get; set; }
        [NotMapped]
        public virtual Estado Destino { get; set; }

        [NotMapped]
        public virtual IEnumerable<Estado> Estados { get; set; }


        [NotMapped]
        public IEnumerable<SelectListItem> EstadoLista { get; set; }

        //public TimeSpan Dur2acao(DateTime Ida, DateTime Volta)
        //{
        //    TimeSpan DiasTotaisDeViagem = Volta.Subtract(Ida);
        //    return DiasTotaisDeViagem.Days;
        //}

        public static int Duracao(DateTime Ida, DateTime Volta)
        {
            int dias;
            TimeSpan TempoDecorrido = Volta.Subtract(Ida);

            dias = TempoDecorrido.Days;

            return dias;
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