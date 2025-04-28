using System.Collections.Generic;
using System.Linq;

namespace PasswordStrengthService
{
    // Implements the IService1 interface to evaluate password strength
    public class Service1 : IService1
    {
        // Analyzes the given password and returns a PasswordFeedback object
        public PasswordFeedback CheckStrength(string password)
        {
            var issues = new List<string>(); // Stores any detected weaknesses
            int score = 0; // Used to calculate overall strength level

            // Check for minimum length
            if (password.Length < 8)
                issues.Add("Password should be at least 8 characters long.");
            else
                score++;

            // Check for uppercase letters
            if (!password.Any(char.IsUpper))
                issues.Add("Include at least one uppercase letter.");
            else
                score++;

            // Check for lowercase letters
            if (!password.Any(char.IsLower))
                issues.Add("Include at least one lowercase letter.");
            else
                score++;

            // Check for numeric digits
            if (!password.Any(char.IsDigit))
                issues.Add("Include at least one number.");
            else
                score++;

            // Check for special characters
            if (!password.Any(c => "!@#$%^&*()_+-=[]{}|;':\",.<>?/\\`~".Contains(c)))
                issues.Add("Include at least one special character.");
            else
                score++;

            // Determine strength based on score
            string strength;
            if (score >= 5)
                strength = "Strong";
            else if (score >= 3)
                strength = "Medium";
            else
                strength = "Weak";

            // Return the strength and the list of improvement suggestions
            return new PasswordFeedback
            {
                Strength = strength,
                Issues = issues.ToArray()
            };
        }
    }
}
