using System.Web;
using System.Web.Mvc;

namespace Web_API_using_asp.net_web_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
