using Aula03_EF.Models;
using System.Data.Entity;

namespace Aula03_EF.Contexto
{
    public class AulaContext : DbContext
    {
        public AulaContext() : base("MyContext")
        {

        }

        public DbSet<Artigo> Artigos { get; set; }
    }
}
