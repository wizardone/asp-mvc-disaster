using System;
using System.Web;
namespace sample
{
	public class SyncModule : IHttpModule
	{
		public void Dispose() { }

		public void Init(HttpApplication app)
		{
			app.AuthenticateRequest += new EventHandler(OnAuthenticateRequest);
		}

		public void OnAuthenticateRequest(Object s, EventArgs e)
		{
			HttpApplication app = s as HttpApplication;
			app.Context.Response.Write("Hello from OnAuthenticateRequest in custom SyncModule.<br>");
		}

		public delegate void MyEventHandler(Object s, EventArgs e);
	}
}
