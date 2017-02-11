using System.Web.Mvc;
using System.Web.Routing;

namespace sample
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				name: "Default",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			);
			routes.MapRoute(
				name: "Empty",
				url: "{controller}/{action}",
				defaults: new { controller = "Home", action = "Empty"}
			);
			routes.MapRoute(
				name: "Articles",
				url: "{controller}/{action}",
				defaults: new { controller = "Article", action = "Index" }
			);
			routes.MapRoute(
				name: "ArticleNew",
				url: "{controller}/{action}",
				defaults: new { controller = "Article", action = "New"}
			);
			routes.MapRoute(
				name: "Article",
				url: "{controller}/{action}/{id}",
				defaults: new { controller = "Article", action = "Show" },
				constraints: new { id = @"\d+" }
			);
// some comment here
		}
	}
}
