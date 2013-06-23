using System.Web.Mvc;

namespace MvcApplication5
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new CustomHandleErrorAttribute());
		}
	}

	public class CustomHandleErrorAttribute : HandleErrorAttribute
	{
		public override void OnException(ExceptionContext filterContext)
		{
			if (filterContext.Exception is CustomException) {
				filterContext.Result = new RedirectResult("~/Home/Error");
				filterContext.ExceptionHandled = true;
				return;
			}
			base.OnException(filterContext);
		}
	}
}