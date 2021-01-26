using System.Data.Entity;

namespace Elkin.Models
{
    public class AppCtx: DbContext
    {
        public AppCtx() : base("DefaultConnection")
        {
        }

        public DbSet<Buyer> Courses { get; set; }
    }
}