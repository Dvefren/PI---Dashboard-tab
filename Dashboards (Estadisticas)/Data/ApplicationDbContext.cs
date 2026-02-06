using Microsoft.EntityFrameworkCore;

namespace Universidad.Data  // <--- NOMBRE NUEVO Y ÚNICO
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}