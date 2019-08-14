using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SeguroViagem.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [DisplayName("Usuário")]
        [Required(ErrorMessage = "Digite seu usuário.")]
        public string UserName { get; set; }


        [DisplayName("Senha")]
        [Required(ErrorMessage = "Digite sua senha.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [NotMapped]
        public string LoginErrorMessage { get; set; }
    }
}

