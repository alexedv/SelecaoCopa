using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using WebMatrix.Data;

namespace K19_CopaDoMundo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            /*
            AreaRegistration.RegisterAllAreas();
            
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<K19_CopaDoMundo.Models.CopaDoMundoContext>());
                       
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
             * */           
        }
       
    }
}
