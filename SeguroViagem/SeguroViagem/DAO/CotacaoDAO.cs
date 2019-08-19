using SeguroViagem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SeguroViagem.DAO
{
    public class CotacaoDAO
    {
        public SeguroViagemContexto db = new SeguroViagemContexto();

        /* Aqui eu só preciso da minha interface para cotação e salvar as informações que o usuário (cliente) irá digitar. */
        public void Adicionar(Cotacao cotacao)
        {
            cotacao.QtdeDias = Cotacao.Duracao(cotacao.Ida, cotacao.Volta);
            db.Cotacoes.Add(cotacao);
            db.SaveChanges();
        }
                
        //public void Lista()
        //{

        //}
    }
}