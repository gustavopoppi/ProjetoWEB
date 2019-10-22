using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models.Enum
{
    // Estou transformando as opções em Enum, e setando cada string para um valor.
    
    public enum MotivoViagemEnum
    {
        Lazer = 1,
        Estudo = 2,
        Negócios = 3
    }
}