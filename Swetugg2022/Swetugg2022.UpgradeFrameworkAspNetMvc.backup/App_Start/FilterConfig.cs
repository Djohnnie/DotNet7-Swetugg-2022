using System.Web;
using System.Web.Mvc;

namespace Swetugg2022.UpgradeFrameworkAspNetMvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
