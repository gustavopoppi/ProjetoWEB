using SeguroViagem.DAO;
using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.Business
{
    public class DropDownEstados
    {
        SeguroViagemContexto context = new SeguroViagemContexto();
        public IEnumerable<SelectListItem> GetAll()
        {
            var list = new Cotacao();
            IEnumerable<SelectListItem> ListaEstado = from item in context.Estados
                                                       select new SelectListItem
                                                       {
                                                           Selected = item.EstadoId.ToString() == "active",
                                                           Text = item.Estados,
                                                           Value = item.EstadoId.ToString()
                                                       };
            return ListaEstado;
        }
    }
}