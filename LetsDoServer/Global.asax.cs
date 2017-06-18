using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using LetsDoServer.DataAccessLayer;
using System.Data.Entity;

namespace LetsDoServer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            DbContext db = new DataContext();
            Database.SetInitializer(new DataInitializer());
            DataContext c = new DataContext();
            c.Database.Initialize(true);
        }
    }
}
