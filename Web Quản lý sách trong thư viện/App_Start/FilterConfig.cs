using System.Web;
using System.Web.Mvc;

namespace Web_Quản_lý_sách_trong_thư_viện
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
