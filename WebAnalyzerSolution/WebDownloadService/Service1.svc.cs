using System;
using System.Net;

namespace WebDownloadService
{
    // Implements the IService1 interface to provide web content downloading functionality
    public class Service1 : IService1
    {
        // Downloads and returns the raw HTML content of the provided URL
        public string WebDownload(string url)
        {
            try
            {
                // Create a WebClient instance to fetch the content
                using (WebClient client = new WebClient())
                {
                    // Download and return the page content as a string
                    return client.DownloadString(url);
                }
            }
            catch (Exception ex)
            {
                // Return a readable error message if download fails
                return $"Error: {ex.Message}";
            }
        }
    }
}
