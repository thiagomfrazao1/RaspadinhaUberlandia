using Microsoft.EntityFrameworkCore;
using RaspadinhaDigital.API.Models;
using static RaspadinhaDigital.API.Controllers.UserController;

namespace RaspadinhaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }
    }
}
