using Microsoft.EntityFrameworkCore;
using Task4_userAPI.Models;

namespace Task4_userAPI.Contex
{
    public class MVCContext : DbContext
    {
        public MVCContext(DbContextOptions<MVCContext> options) : base(options)
        {

        }
        public DbSet<user> users { set; get; } = null!;
    }
   
}
