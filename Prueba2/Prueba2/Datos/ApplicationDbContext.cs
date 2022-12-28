using Microsoft.EntityFrameworkCore;
using Prueba2.Models;

namespace Prueba2.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        public DbSet<Contacto> Contacto { get; set; }
    }
}
