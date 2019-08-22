using System;
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
        public Seguradora() {
            AcrescimosViagens = new List<AcrescimoTipoViagem>
            {
                // Ao inicializar a página o valor carregado será 0
                new AcrescimoTipoViagem
                {                    
                    TipoViagem = Enum.TipoViagemEnum.Nacional,
                    AcrescimoViagem = 0
                },
                new AcrescimoTipoViagem
                {
                    TipoViagem = Enum.TipoViagemEnum.Internacional,
                    AcrescimoViagem = 0
                }
            };
            AcrescimosTransportes = new List<AcrescimoMeioTransporte>
            {
                new AcrescimoMeioTransporte
                {
                    MeioTransporte = Enum.MeioTransporteEnum.Áereo ,
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
            
            AcrescimosMotivos = new List<AcrescimoMotivoViagem>
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

        }

        [Key]
        public int SegId { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Nome Seguradora")]
        public string NomeSeg { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Comissão")]
        public int Comissao { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Extravio Bagagem")]
        public Nullable<decimal> ExtBagagem { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Morte Acidental")]
        public Nullable<decimal> MorteAcid { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Translado de Corpo")]
        public Nullable<decimal> TransCorpo { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Invalidez Permanente")]
        public Nullable<decimal> InvalidezPerm { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Despesas Farmácia")]
        public Nullable<decimal> DespesasFarmacia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Valor por Dia:")]
        public double ValorPorDia { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório.")]
        [DisplayName("Valor por Pessoa:")]
        public double ValorPorPessoa { get; set; }

        [NotMapped]
        public double Valor { get; set; }

        [NotMapped]
        public IList<Cotacao> Cotacoes { get; set; }

        [NotMapped]
        public IList<AcrescimoTipoViagem> AcrescimosViagens { get; set; }

        [NotMapped]
        public IList<AcrescimoMeioTransporte> AcrescimosTransportes { get; set; }

        [NotMapped]
        public IList<AcrescimoMotivoViagem> AcrescimosMotivos { get; set; }

    }
}