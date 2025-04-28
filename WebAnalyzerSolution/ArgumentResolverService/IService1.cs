using System.ServiceModel;

namespace ArgumentResolverService
{
    // Define a service contract for the WCF service
    [ServiceContract]
    public interface IService1
    {
        // This operation takes an argument/conflict description as input
        // and returns an AI-generated suggestion for resolving it.
        [OperationContract]
        string ResolveArgument(string argument);
    }
}
