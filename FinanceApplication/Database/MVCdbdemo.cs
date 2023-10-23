using FinanceApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace FinanceApplication.Database
{
    public class MVCdbdemo : DbContext
    {
        public MVCdbdemo(DbContextOptions options) : base(options) { }
         public DbSet<domain> domain { get; set; }
        public DbSet<transaction> transaction { get; set; } 
        public DbSet<entity> entities { get; set; }
    } }
        
