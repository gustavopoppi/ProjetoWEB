using SeguroViagem.Models;
using SeguroViagem.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO
{
    public class AcrescimoViagemDAO
    {
        private SeguroViagemContexto db = new SeguroViagemContexto();

        //public AcrescimoTipoViagem ObterPorSeguradora(int segId, TipoViagemEnum tipoViagem)
        //{

        //    return db.AcrescimoTipoViagem.where(x => x.SegId == segId && x.TipoViagem == tipoViagem).FirstOrDefault();
        //}
    }
}