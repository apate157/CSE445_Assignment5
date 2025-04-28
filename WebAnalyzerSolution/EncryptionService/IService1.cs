using System.ServiceModel;

// Define the WCF service contract for the encryption service
[ServiceContract]
public interface IService1
{
    // Encrypts the input string using a Caesar cipher with the given shift value
    // Example: input = "hello", shift = 3 → output = "khoor"
    [OperationContract]
    string Encrypt(string input, int shift);

    // Decrypts the input string that was encrypted using a Caesar cipher
    // Example: input = "khoor", shift = 3 → output = "hello"
    [OperationContract]
    string Decrypt(string input, int shift);
}
