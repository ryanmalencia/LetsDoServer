using System.Data.Entity;

namespace LetsDoServer.DataAccessLayer
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DataContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}