using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample.Controllers
{
    public class FormController : Controller
    {
		public ContentResult Index()
		{
			//return "This is the form controller, index action";
			return Content();
		}
    }
}
