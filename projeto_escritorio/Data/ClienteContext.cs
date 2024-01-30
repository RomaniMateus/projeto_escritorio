using Microsoft.EntityFrameworkCore;
using projeto_escritorio.Models;

namespace projeto_escritorio.Data
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext>opts) : base(opts)
        {
        
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Loja> Lojas { get; set; }
        public DbSet<Divida> Dividas { get; set; }
    }
}
