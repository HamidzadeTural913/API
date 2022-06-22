using ApiFirst_Codes.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFirst_Codes.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
        public DbSet<Product> Products { get; set; }    
    }
}
