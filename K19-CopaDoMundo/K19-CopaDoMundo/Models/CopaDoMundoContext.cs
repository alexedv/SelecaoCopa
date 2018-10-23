using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace K19_CopaDoMundo.Models
{
    public class CopaDoMundoContext : DbContext
    {
        public DbSet<Selecao> Selecoes { get; set; }
        public DbSet<Jogador> Jogadores { get; set; }
    }
}