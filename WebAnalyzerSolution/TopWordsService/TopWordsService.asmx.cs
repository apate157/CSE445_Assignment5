using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web.Services;

// Define the web service and binding
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class TopWordsHandler : WebService
{
    // Web method that takes a URL and returns the top 10 most frequent content words
    [WebMethod]
    public string[] Top10ContentWords(string url)
    {
        try
        {
            // Download the HTML content from the specified URL
            string html = new WebClient().DownloadString(url);

            // Remove HTML tags using a regular expression
            string text = Regex.Replace(html, "<.*?>", " ");

            // Define common stopwords to exclude from analysis
            string[] stopwords = { "a", "an", "the", "is", "are", "in", "on", "of", "to", "and" };

            // Process the plain text:
            // - Convert to lowercase
            // - Split on common delimiters
            // - Remove short words and stopwords
            // - Group and count word frequency
            // - Take the top 10 most frequent content words
            var words = text.ToLower()
                            .Split(new[] { ' ', '\n', '\r', '.', ',', '?', '!', ':', ';', '-', '\"', '\'' }, StringSplitOptions.RemoveEmptyEntries)
                            .Where(w => !stopwords.Contains(w) && w.Length > 2)
                            .GroupBy(w => w)
                            .OrderByDescending(g => g.Count())
                            .Take(10)
                            .Select(g => g.Key)
                            .ToArray();

            return words;
        }
        catch (Exception ex)
        {
            // Return error message as a single-item array
            return new[] { $"Error: {ex.Message}" };
        }
    }
}
