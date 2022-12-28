using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Net7.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Net7.Datos
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        //Agregar los modelos aquí
        public DbSet<Contacto> Contacto { get; set; }

    }
}