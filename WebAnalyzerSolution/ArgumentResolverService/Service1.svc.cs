using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;

namespace ArgumentResolverService
{
    // Implementation of the IService1 interface
    public class Service1 : IService1
    {
        // Gemini 1.5 Flash API key
        private readonly string apiKey = "AIzaSyCXnE_HV-n1Rf-unKQ1vbdL2MyXyO9cQLI";

        // Base URL for Gemini Flash model content generation endpoint
        private readonly string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key=";

        // Main method to handle the conflict resolution request
        public string ResolveArgument(string argument)
        {
            try
            {
                // Construct the prompt with additional context for better AI response
                var prompt = $"Suggest a helpful and respectful way to resolve this conflict:\n\"{argument}\"";

                // Format the request payload expected by Gemini API
                var requestData = new
                {
                    contents = new[]
                    {
                        new
                        {
                            parts = new[]
                            {
                                new { text = prompt } // Pass the prompt as a "part" of the conversation
                            }
                        }
                    }
                };

                // Convert the request object to JSON
                string jsonRequest = new JavaScriptSerializer().Serialize(requestData);

                // Set up the HTTP POST request to Gemini API
                var request = (HttpWebRequest)WebRequest.Create(apiUrl + apiKey);
                request.Method = "POST";
                request.ContentType = "application/json";

                // Write the JSON payload into the request stream
                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(jsonRequest);
                }

                // Get the API response
                var response = (HttpWebResponse)request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    string resultJson = reader.ReadToEnd();

                    // Deserialize the response into GeminiResponse object
                    var json = new JavaScriptSerializer().Deserialize<GeminiResponse>(resultJson);

                    // Return the first generated response text from the AI
                    if (json != null &&
                        json.candidates != null &&
                        json.candidates.Length > 0 &&
                        json.candidates[0].content.parts.Length > 0)
                    {
                        return json.candidates[0].content.parts[0].text;
                    }

                    // Fallback if no response was generated
                    return "The AI could not generate a helpful suggestion.";
                }
            }
            catch (Exception ex)
            {
                // Return any exception message as part of the response for debugging
                return $"Error: {ex.Message}";
            }
        }
    }

    // Classes for parsing the JSON response from Gemini API
    public class GeminiResponse
    {
        public Candidate[] candidates { get; set; }
    }

    public class Candidate
    {
        public Content content { get; set; }
    }

    public class Content
    {
        public Part[] parts { get; set; }
    }

    public class Part
    {
        public string text { get; set; }
    }
}
