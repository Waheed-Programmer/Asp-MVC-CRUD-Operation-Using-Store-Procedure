using System.Web;
using System.Web.Mvc;

namespace MVC_CRUD_Operation_Store_Procedure
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
