using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeguroViagem.DAO
{
    public class DadosViajanteDAO
    {
        SeguroViagemContexto db = new SeguroViagemContexto();

        //Void não tem retorno
        public void Adicionar(DadosViajante dadosViajante)
        {
            db.DadosViajantes.Add(dadosViajante);
            db.SaveChanges();
        }
    }
}