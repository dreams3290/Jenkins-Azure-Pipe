using System.Web;
using System.Web.Mvc;

namespace Jenkins_Azure_Pipe
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
