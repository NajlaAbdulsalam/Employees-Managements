using Employees_Managements.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employees_Managements.Data
    {
    public class DataContext :DbContext
        {
        public DataContext(DbContextOptions options):base(options)
            { 
            }
        
     public DbSet<AppUser> Users { get; set; }
        }
    }
