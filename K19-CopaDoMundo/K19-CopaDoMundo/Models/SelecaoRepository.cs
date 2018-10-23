using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace K19_CopaDoMundo.Models
{
    public class SelecaoRepository : IDisposable
    {
        private bool disposed = false;

        private CopaDoMundoContext context;

        public SelecaoRepository(CopaDoMundoContext context)
        {
            this.context = context;
        }

        public void Adiciona(Selecao selecao)
        {
            context.Selecoes.Add(selecao);
        }

        public List<Selecao> Selecoes
        {
            get
            {
                return context.Selecoes.ToList();
            }
        }
        
        public void Salva()
        {
            context.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public Selecao Busca(int id)
        {
            return context.Selecoes.Find(id);
        }
        public void Remove(int id)
        {
            Selecao selecao = Busca(id);
            context.Selecoes.Remove(selecao);
        }
    }
}