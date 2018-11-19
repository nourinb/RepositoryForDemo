using System.Web;
using System.Web.Mvc;

namespace WebApplicationForJenkinsWithGit
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
