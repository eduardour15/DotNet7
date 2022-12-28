using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace prueba.Datos
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) 
        {
                    
        }

        //Por aca iran los modelos
        public DbSet<Contacto> Contacto { get; set; }
    }
}
