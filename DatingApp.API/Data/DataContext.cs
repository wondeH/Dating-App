using DatingApp.API.Models;
using Microsoft.EntityFrameworkCore; //allows us to use Dbcontext 

namespace DatingApp.API.Data
{
    public class DataContext : DbContext 
    {
    
        public DataContext(DbContextOptions<DataContext> options) : base(options){} 

        //telling our data context class about our entities 
        public DbSet<Value> Values { get; set; }
    }
}