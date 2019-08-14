using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO
{

    // O que significa firstofdefault
    public class SeguradoraDAO
    {
        public SeguroViagemContexto db = new SeguroViagemContexto();

        public void Adicionar(Seguradora seguradora)
        {
            db.Seguradoras.Add(seguradora);
            db.SaveChanges();
        }

        public IList<Seguradora> Lista()
        {
            return db.Seguradoras.ToList();
        }

        public void Atualizar (Seguradora seguradora)
        {
            db.Seguradoras.Update(seguradora);
            //db.SaveChanges(); não tem q ter esse saavechanges?
        }

        public void Remover (Seguradora seguradoras)
        {
            int id = 0;
            db.Seguradoras.Where(f => f.SegId == id).FirstOrDefault();
            db.Seguradoras.Remove(seguradoras);
            db.SaveChanges();
        }
        public Seguradora BuscarPorId(int id)
        {
            return db.Seguradoras.Where(f => f.SegId == id).FirstOrDefault();
        }
    }
}