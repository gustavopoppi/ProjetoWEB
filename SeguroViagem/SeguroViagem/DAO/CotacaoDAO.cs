using Microsoft.EntityFrameworkCore;
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

        public IList<Cotacao> Lista()
        {

            return db.Cotacoes.Include(c => c.Origem).Include(c => c.Destino).ToList();

        }

        public void Atualizar(Cotacao cotacao)
        {
            db.Cotacoes.Update(cotacao);
            db.SaveChanges();
        }

        public void Remover(Cotacao cotacao)
        {
            int id = 0;
            db.Cotacoes.Where(f => f.CotId == id).FirstOrDefault();
            db.Cotacoes.Remove(cotacao);
            db.SaveChanges();
        }
        public Cotacao BuscarPorId(int id)
        {
            return db.Cotacoes.Where(f => f.CotId == id).FirstOrDefault();
        }
    }
}