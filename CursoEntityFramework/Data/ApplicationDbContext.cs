using CursoEntityFramework.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoEntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // write models
        public DbSet<Category> Category { get; set; }
        public DbSet<User> User { get; set; }

        // when should I create migrations
        /*
         * 1. Cuando se crea una nueva clase (tabla en la bd)
         * 2. Cuando agregue una nueva propiedad (crear un campo nuevo en la bd)
         * 3. Modifique un valor de campo en la clase (modificar campo en bd)
         */
    }
}
