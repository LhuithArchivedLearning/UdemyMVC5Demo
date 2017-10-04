using System.Data.Entity.Core.Metadata.Edm;
using System.Web;
using System.Web.Mvc;

namespace Vidly
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add((new AuthorizeAttribute()));
            filters.Add(new RequireHttpsAttribute());
        }
    }
}
