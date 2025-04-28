using System.Linq;

namespace EncryptionService
{
    // Implements the IService1 interface for Caesar cipher encryption and decryption
    public class Service1 : IService1
    {
        // Encrypts the input by shifting each character forward by the given shift value
        // Example: input = "abc", shift = 2 → output = "cde"
        public string Encrypt(string input, int shift)
        {
            // For each character in the input, add the shift value to its character code
            return new string(input.Select(c => (char)(c + shift)).ToArray());
        }

        // Decrypts the input by shifting each character backward by the given shift value
        // Example: input = "cde", shift = 2 → output = "abc"
        public string Decrypt(string input, int shift)
        {
            // For each character in the input, subtract the shift value from its character code
            return new string(input.Select(c => (char)(c - shift)).ToArray());
        }
    }
}
