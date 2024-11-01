using System.Web;
using System.Web.Mvc;

namespace CNT2_LeXuanToan_2210900069
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
