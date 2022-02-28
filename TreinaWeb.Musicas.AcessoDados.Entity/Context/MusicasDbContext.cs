using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TreinaWeb.Musicas.Dominio;

namespace TreinaWeb.Musicas.AcessoDados.Entity.Context
{
    public class MusicasDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }
    }
}
