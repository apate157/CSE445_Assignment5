using System;
using TryItWebApp.ArgumentResolverService; // Namespace generated when adding the service reference

namespace TryItWebApp
{
    // Code-behind for the ArgumentTryIt.aspx page
    public partial class ArgumentTryIt : System.Web.UI.Page
    {
        // Event handler for the "Resolve" button click
        protected void btnResolve_Click(object sender, EventArgs e)
        {
            try
            {
                // Save input in cookie
                Response.Cookies["lastArgument"].Value = txtArgument.Text;
                Response.Cookies["lastArgument"].Expires = DateTime.Now.AddDays(1);

                // Create a client proxy for the WCF ArgumentResolverService
                var client = new Service1Client();

                // Call the ResolveArgument method with the user's input
                string result = client.ResolveArgument(txtArgument.Text);

                // Display the result in the label, replacing newline characters with <br /> for web formatting
                lblResponse.Text = result.Replace("\n", "<br />");
            }
            catch (Exception ex)
            {
                // Display any error messages encountered during service call
                lblResponse.Text = "Error: " + ex.Message;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.Cookies["lastArgument"] != null)
            {
                txtArgument.Text = Request.Cookies["lastArgument"].Value;
            }
        }

    }
}
