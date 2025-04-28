using System;
using TryItWebApp.WebDownloadService; // Namespace from the service reference for WebDownloadService

namespace TryItWebApp
{
    // Code-behind for the WebDownloadTryIt.aspx page
    public partial class WebDownloadTryIt : System.Web.UI.Page
    {
        // Event handler for the "Download HTML" button click
        protected void btnDownload_Click(object sender, EventArgs e)
        {
            // Create a client proxy for the WebDownloadService
            var client = new Service1Client();

            // Call the WebDownload method with the provided URL and display the raw HTML content
            litResult.Text = client.WebDownload(txtUrl.Text);
        }
    }
}
