using System.Web;

namespace StudentEF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new FlushLogAttribute());
        }
    }

    public class FlushLogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            
            base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }
    }

    public class Test : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            int a;
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            int a;
        }
    }
}
