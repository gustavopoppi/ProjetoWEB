using Microsoft.EntityFrameworkCore;
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

            // n entendi mto bem.
            foreach (var acrescimoTipoViagem in seguradora.AcrescimosViagens)
            {
                acrescimoTipoViagem.SegId = seguradora.SegId;
                db.AcrescimosTipoViagem.Add(acrescimoTipoViagem);
            }

            foreach (var acrescimoMeioTransporte in seguradora.AcrescimosTransportes)
            {
                acrescimoMeioTransporte.SegId = seguradora.SegId;
                db.AcrescimosMeioTransporte.Add(acrescimoMeioTransporte);
            }

            foreach (var acrescimoMotivoViagem in seguradora.AcrescimosMotivos)
            {
                acrescimoMotivoViagem.SegId = seguradora.SegId;
                db.AcrescimosMotivoViagem.Add(acrescimoMotivoViagem);
            }

            db.SaveChanges();

        }

        public IList<Seguradora> Lista()
        {
            return db.Seguradoras.ToList();
        }

        public void Atualizar(Seguradora seguradora)
        {
            db.Seguradoras.Update(seguradora);
            db.SaveChanges();
        }

        public void Remover(Seguradora seguradoraRemover)
        {
            var seguradora = db.Seguradoras.Include(c => c.AcrescimosMotivos).Include(c => c.AcrescimosTransportes).Include(c => c.AcrescimosViagens).Where(f => f.SegId == seguradoraRemover.SegId).FirstOrDefault();
            foreach (var acrescimoViagem in seguradora.AcrescimosViagens.ToList())
            {
                db.AcrescimosTipoViagem.Remove(acrescimoViagem);
            }
            foreach (var acrescimoMotivo in seguradora.AcrescimosMotivos)
            {
                db.AcrescimosMotivoViagem.Remove(acrescimoMotivo);
            }
            foreach (var acrescimosTransporte in seguradora.AcrescimosTransportes)
            {
                db.AcrescimosMeioTransporte.Remove(acrescimosTransporte);
            }
            db.Seguradoras.Remove(seguradora);
            db.SaveChanges();
        }
        public Seguradora BuscarPorId(int id)
        {
            return db.Seguradoras.Where(f => f.SegId == id).FirstOrDefault();
        }
    }
}