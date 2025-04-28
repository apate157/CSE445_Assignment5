using System;
using TryItWebApp.EncryptionService; // Namespace generated from the service reference

namespace TryItWebApp
{
    // Code-behind for the EncryptTryIt.aspx page
    public partial class EncryptTryIt : System.Web.UI.Page
    {
        // Event handler for the "Encrypt" button click
        protected void btnEncrypt_Click(object sender, EventArgs e)
        {
            // Create a client proxy for the encryption service
            var client = new Service1Client();

            // Parse the shift value entered by the user
            int shift = int.Parse(txtShift.Text);

            // Call the Encrypt method and display the result
            lblResult.Text = client.Encrypt(txtInput.Text, shift);
        }

        // Event handler for the "Decrypt" button click
        protected void btnDecrypt_Click(object sender, EventArgs e)
        {
            // Create a client proxy for the encryption service
            var client = new Service1Client();

            // Parse the shift value entered by the user
            int shift = int.Parse(txtShift.Text);

            // Call the Decrypt method and display the result
            lblResult.Text = client.Decrypt(txtInput.Text, shift);
        }
    }
}
