using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.Business
{
    public class CalculaValor
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();
        public List<Seguradora> CalculaValorCotacao(Cotacao cotacao)
        {

            var listaSeguradoras = db.Seguradoras.ToList();
            //foreach (var seguradora in listaSeguradoras)
            //{
            //    seguradora.Valor = // regra para criar o valor

            //   var acrescimoViagem = new AcrescimoViagemDAO().ObterPorSeguradora(seguradora.SegId, cotacao.TipoViagem);

            //    if acrescimoViagem == null {
            //        acrescimo = 0;
            //    }

            //    var acrescimoMeio = db.AcrescimoMeioViagem.where(x => x.SegId == seguradora.SegId && x.TipoViagem == cotacao.TipoViagem).FirstOrDefault();

            //    if acrescimo == null {
            //        acrescimo = 0;
            //    }

            //    seguradora.Valor = acrescimoViagem + acrescimo + asda + asdads
            //}


            //return listaSeguradoras;
            return listaSeguradoras;
        }
    }
}