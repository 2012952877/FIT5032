using System.Web;
using System.Web.Mvc;

namespace FIT5032_Assignment_E_Karaoke_application
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
