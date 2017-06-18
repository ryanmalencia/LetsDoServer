using System.Data.Entity;

namespace LetsDoServer.DataAccessLayer
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            context.SaveChanges();
        }
    }
}