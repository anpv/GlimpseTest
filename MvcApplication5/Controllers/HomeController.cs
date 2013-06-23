using Ext.Net.MVC;
using System.Web.Mvc;

namespace MvcApplication5.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Test()
		{
			throw new CustomException();
		}

		public ActionResult Error()
		{
			return this.PartialExtView();
		}
	}
}
