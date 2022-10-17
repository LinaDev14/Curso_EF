using Microsoft.EntityFrameworkCore;

namespace CursoEntityFramework.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // write models

    }
}
