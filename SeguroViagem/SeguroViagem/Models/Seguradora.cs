﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DisplayName("Comissão(%)")]
        [Range(10, 100, ErrorMessage = "Valor mínimo da comissão é 10 e máximo é 100")]
        public int Comissao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Extravio Bagagem(R$)")]
        public Nullable<decimal> ExtBagagem { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Morte Acidental(R$)")]
        public Nullable<decimal> MorteAcid { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Translado de Corpo(R$)")]
        public Nullable<decimal> TransCorpo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Invalidez Permanente(R$)")]
        public Nullable<decimal> InvalidezPerm { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Despesas Farmácia(R$)")]
        public Nullable<decimal> DespesasFarmacia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Valor por Dia (%):")]
        public double? ValorPorDia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Valor por Pessoa(%):")]
        public double? ValorPorPessoa { get; set; }

        [NotMapped]
        [Range(10, 100, ErrorMessage = "Valor mínimo da comissão é 10 e máximo é 100")]
        public double? Valor { get; set; }

        [NotMapped]
        [Range(10, 100, ErrorMessage = "Valor mínimo da comissão é 10 e máximo é 100")]
        public int CotdId { get; set; }

        [NotMapped]
        public IList<Cotacao> Cotacoes { get; set; }


        public IList<AcrescimoTipoViagem> AcrescimosViagens { get; set; }


        public IList<AcrescimoMeioTransporte> AcrescimosTransportes { get; set; }


        public IList<AcrescimoMotivoViagem> AcrescimosMotivos { get; set; }

        public Seguradora inicializar()
        {
            var seguradora = new Seguradora();
            seguradora.AcrescimosViagens = new List<AcrescimoTipoViagem>
            {
                // Ao inicializar a página o valor carregado será 0
                new AcrescimoTipoViagem
                {
                    TipoViagem = Enum.TipoViagemEnum.Nacional,
                    AcrescimoViagem = 0
                },
                //new AcrescimoTipoViagem
                //{
                //    TipoViagem = Enum.TipoViagemEnum.Internacional,
                //    AcrescimoViagem = 0
                //}
            };
            seguradora.AcrescimosTransportes = new List<AcrescimoMeioTransporte>
            {
                new AcrescimoMeioTransporte
                {
                    MeioTransporte = Enum.MeioTransporteEnum.Aéreo ,
                    AcrescimoTransporte = 0
                },
                new AcrescimoMeioTransporte
                {
                    MeioTransporte = Enum.MeioTransporteEnum.Marítimo,
                    AcrescimoTransporte = 0
                },
                new AcrescimoMeioTransporte
                {
                    MeioTransporte = Enum.MeioTransporteEnum.Ambos,
                    AcrescimoTransporte = 0
                }
            };

            seguradora.AcrescimosMotivos = new List<AcrescimoMotivoViagem>
            {
                new AcrescimoMotivoViagem
                {
                    MotivoViagem = Enum.MotivoViagemEnum.Lazer,
                    AcrescimoMotivo = 0
                },
                new AcrescimoMotivoViagem
                {
                    MotivoViagem = Enum.MotivoViagemEnum.Estudo,
                    AcrescimoMotivo = 0
                },
                new AcrescimoMotivoViagem
                {
                    MotivoViagem = Enum.MotivoViagemEnum.Negócios,
                    AcrescimoMotivo = 0
                }
            };
            return seguradora;
        }
        public enum Acrescimo
        {
            Transporte,
            Motivo,
            Viagem
        }

    }
}