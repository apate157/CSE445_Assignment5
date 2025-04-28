using System.Runtime.Serialization;
using System.ServiceModel;

namespace PasswordStrengthService
{
    // Define the WCF service contract for evaluating password strength
    [ServiceContract]
    public interface IService1
    {
        // This operation analyzes the given password and returns a feedback object
        // containing the strength level and suggestions for improvement
        [OperationContract]
        PasswordFeedback CheckStrength(string password);
    }

    // Define the structure of the feedback returned by the service
    [DataContract]
    public class PasswordFeedback
    {
        // Strength value: "Weak", "Medium", or "Strong"
        [DataMember]
        public string Strength { get; set; }

        // Array of reasons why the password may be weak (e.g., missing digits or symbols)
        [DataMember]
        public string[] Issues { get; set; }
    }
}
