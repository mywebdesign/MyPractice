using System.Data.Entity;
using System.Configuration;

namespace FitHolic.Models.Data
{
    public class FitHolicDbContext:DbContext
    {
        public FitHolicDbContext() : base(ConfigurationManager.ConnectionStrings["FitholicDBConnection"].ConnectionString)
        {

        }
        public DbSet<User> Users { get; set; }

    }
}