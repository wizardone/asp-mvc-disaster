using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace sample.Controllers
{
    public class ArticleController : Controller
    {
		[HttpGet]
        public ActionResult Index()
        {
            return View ();
        }

		[HttpGet]
		public ActionResult Show()
		{
			return View();
		}

		[HttpGet]
		public ActionResult New()
		{
			return View();
		}

		[HttpPost]
		public RedirectResult Create(Article article)
		{
			Trace.TraceError(article.Title);
			     
			return Redirect("Index");
		}
    }
}
