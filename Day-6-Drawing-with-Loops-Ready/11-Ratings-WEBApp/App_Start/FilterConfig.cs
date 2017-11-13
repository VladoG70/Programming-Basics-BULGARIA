using System.Web;
using System.Web.Mvc;

namespace _11_Ratings_WEBApp
    {
    public class FilterConfig
        {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
            {
            filters.Add(new HandleErrorAttribute());
            }
        }
    }
