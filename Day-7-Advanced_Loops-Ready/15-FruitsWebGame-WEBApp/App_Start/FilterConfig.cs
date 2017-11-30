using System.Web;
using System.Web.Mvc;

namespace _15_FruitsWebGame_WEBApp
    {
    public class FilterConfig
        {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
            {
            filters.Add(new HandleErrorAttribute());
            }
        }
    }
