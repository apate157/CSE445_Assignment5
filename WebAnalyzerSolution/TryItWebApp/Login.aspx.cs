using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;  
using System.Xml.Linq;


namespace TryItWebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
           
            var user = txtUsername.Text.Trim();
            var pass = txtPassword.Text;

            
            var returnUrl = Request.QueryString["ReturnUrl"] ?? "Default.aspx";

            
            var xmlPath = Server.MapPath("~/Member.xml");
            var doc     = XElement.Load(xmlPath);

            
            var match = doc.Elements("User")
                           .FirstOrDefault(u =>
                               (string)u.Element("Username") == user &&
                               (string)u.Element("Password") == pass);

            if (match != null)
            {
               
                FormsAuthentication.SetAuthCookie(user, false);
                Response.Redirect(returnUrl);
            }
            else
            {
               
                lblError.Text = "Invalid credentials.";
            }
        }
    }
}
