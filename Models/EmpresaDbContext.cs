using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class EmpresaDbContext:DbContext
    {
        public EmpresaDbContext(DbContextOptions<EmpresaDbContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresa { get; set; }
    }
}
