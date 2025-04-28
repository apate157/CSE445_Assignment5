using System;
using System.Web;

namespace TryItWebApp
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // Optional: Application-level initialization
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            // Store the session start time in session state
            Session["StartTime"] = DateTime.Now;
        }
    }
}
