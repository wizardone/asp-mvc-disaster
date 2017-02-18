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
		[OutputCache(Duration=120)]
        public ActionResult Index()
        {
            return View ();
        }

		[HttpGet]
		public ActionResult Show()
		{
			return View();
		}

		//[HandleError(ExceptionType=typeof(System.Exception), View="MainException")]
		[HttpGet]
		public ActionResult New()
		{
			throw new System.Exception();
			return View();
		}

		[HttpPost]
		public ActionResult Create(Article article)
		{
			Trace.TraceError(article.Title);
			using (var db = new ArticleContex())
			{
				if (ModelState.IsValid)
				{
					db.Articles.Add(article);
					db.SaveChanges();
					return Redirect("Index");
				}
			}

			return View(article);
		}

		protected override void OnException(ExceptionContext context)
		{
			EventLog.WriteEntry("Exception handled", "Exception");

			if (context.ExceptionHandled)
			{
				return;
			}

			this.View("Error").ExecuteResult(this.ControllerContext);
		}
    }
}
