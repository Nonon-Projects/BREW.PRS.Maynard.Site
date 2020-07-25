using System.Web;
using System.Web.Mvc;

namespace BREW.PRS.Maynard.Site
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
