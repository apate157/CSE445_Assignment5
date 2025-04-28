using System;
using TryItWebApp.TopWordsService; // Namespace from the added web reference to TopWordsHandler

namespace TryItWebApp
{
    // Code-behind for the Top10TryIt.aspx page
    public partial class Top10TryIt : System.Web.UI.Page
    {
        // Event handler for the "Analyze" button click
        protected void btnAnalyze_Click(object sender, EventArgs e)
        {
            // Create an instance of the web service proxy
            var client = new TopWordsHandler();

            // Call the Top10ContentWords method with the entered URL
            string[] topWords = client.Top10ContentWords(txtUrl.Text);

            // Display the top words in the label as a line-separated list
            lblOutput.Text = "<strong>Top Words:</strong><br>" + string.Join("<br>", topWords);
        }
    }
}
