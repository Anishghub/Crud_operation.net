using BestStoreMVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BestStoreMVC.NewFolder
{
    public class ApplicationDbContext : DbContext
         
    {
        public ApplicationDbContext( DbContextOptions options) : base(options) 
        { 
         
        }
       public DbSet<Product> Products { get; set; }
    }
}
