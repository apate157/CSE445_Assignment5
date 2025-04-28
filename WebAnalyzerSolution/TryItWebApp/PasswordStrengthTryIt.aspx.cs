using System;
using TryItWebApp.PasswordStrengthService; // Namespace generated when the service reference was added

namespace TryItWebApp
{
    // Code-behind for the PasswordStrengthTryIt.aspx page
    public partial class PasswordStrengthTryIt : System.Web.UI.Page
    {
        // Event handler for the "Check Strength" button click
        protected void btnCheck_Click(object sender, EventArgs e)
        {
            // Create a client proxy for the PasswordStrengthService
            var client = new Service1Client();

            // Call the CheckStrength method with the entered password
            var result = client.CheckStrength(txtPassword.Text);

            // Display the strength value (e.g., Weak, Medium, Strong)
            lblResult.Text = $"<b>Strength:</b> {result.Strength}<br/>";

            // If there are suggestions for improvement, display them as a bullet list
            if (result.Issues != null && result.Issues.Length > 0)
            {
                lblResult.Text += "<b>Suggestions:</b><ul>";
                foreach (var issue in result.Issues)
                {
                    lblResult.Text += $"<li>{issue}</li>";
                }
                lblResult.Text += "</ul>";
            }
        }
    }
}
