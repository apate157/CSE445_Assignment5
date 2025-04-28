using System.ServiceModel;

// Define the WCF service contract for downloading web page content
[ServiceContract]
public interface IService1
{
    // Downloads and returns the raw HTML content of the specified URL
    [OperationContract]
    string WebDownload(string url);
}
