using Microsoft.EntityFrameworkCore;
using SeguroViagem.Models;
using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO.Acréscimos
{
    public class AcrescimoMeioTransporteDAO
    {
        SeguroViagemContexto db = new SeguroViagemContexto();

        public void Adicionar()
        {
        }
        public IList<AcrescimoMeioTransporte> Lista()
        {

            return db.AcrescimosMeioTransporte.Include(seg => seg.Seguradora).ToList();

        }
        public void Atualizar(AcrescimoMeioTransporte acrescimoMeioTransporte)
        {
            db.AcrescimosMeioTransporte.Update(acrescimoMeioTransporte);
            db.SaveChanges();
        }
        public void Remover(AcrescimoMeioTransporte acrescimoMeioTransporte)
        {
            int id = 0;
            db.AcrescimosMeioTransporte.Where(f => f.TransporteId == id);
            db.AcrescimosMeioTransporte.Remove(acrescimoMeioTransporte);
            db.SaveChanges();
        }
        
        public AcrescimoMeioTransporte BuscarPorId(int id)
        {
            return db.AcrescimosMeioTransporte.Where(f => f.TransporteId == id).FirstOrDefault();
        }


        public AcrescimoMeioTransporte ObterPorMeioTransporte(int segId, MeioTransporteEnum meioTransporte)
        {
            return db.AcrescimosMeioTransporte.Where(x => x.SegId == segId && x.MeioTransporte == meioTransporte).FirstOrDefault();
        }
    }
}