using Microsoft.EntityFrameworkCore;
using NameInverter.Nome.NomeConcreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameInverter.Repositorio
{
    public class MeuContexto : DbContext
    {

        public DbSet<CommonName> Nomes {  get; set; }
        public DbSet<Sobrenome> Sobrenomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=listanomes;Username=postgres;Password=Flafuracao");
        }
    }
}
