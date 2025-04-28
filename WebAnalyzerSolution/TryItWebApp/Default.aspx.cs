using System;
using System.Web.UI.WebControls;

namespace TryItWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Populate service table
                AddServiceRow("Pranjal", "WSDL", "Encrypt", "(string, int) → string", "Encrypts text using Caesar cipher", "EncryptTryIt.aspx");
                AddServiceRow("Pranjal", "WSDL", "Decrypt", "(string, int) → string", "Decrypts Caesar cipher text", "EncryptTryIt.aspx");
                AddServiceRow("Pranjal", "REST", "Top10ContentWords", "(string) → string[]", "Extracts top content words from a web page", "Top10TryIt.aspx");
                AddServiceRow("Pranjal", "WSDL", "WebDownload", "(string) → string", "Downloads raw HTML from URL", "WebDownloadTryIt.aspx");
                AddServiceRow("Pranjal", "WSDL", "CheckStrength", "(string) → object", "Checks password strength and gives suggestions", "PasswordStrengthTryIt.aspx");
                AddServiceRow("Pranjal", "WCF + Gemini API", "ResolveArgument", "(string) → string", "Provides AI-generated resolution for a conflict", "ArgumentTryIt.aspx");
            }

            // This runs every time to show session info
            if (Session["StartTime"] != null)
            {
                lblSessionInfo.Text = "Session started at: " + Session["StartTime"].ToString();
            }
        }

        private void AddServiceRow(string provider, string type, string operation, string signature, string description, string tryItUrl)
        {
            TableRow row = new TableRow();

            row.Cells.Add(new TableCell { Text = provider });
            row.Cells.Add(new TableCell { Text = type });
            row.Cells.Add(new TableCell { Text = operation });
            row.Cells.Add(new TableCell { Text = signature });
            row.Cells.Add(new TableCell { Text = description });
            row.Cells.Add(new TableCell { Text = $"<a href='{tryItUrl}'>TryIt</a>" });

            tblServices.Rows.Add(row);
        }

        protected void btnGoToArgument_Click(object sender, EventArgs e) => Response.Redirect("ArgumentTryIt.aspx");
        protected void btnGoToEncrypt_Click(object sender, EventArgs e) => Response.Redirect("EncryptTryIt.aspx");
        protected void btnGoToTopWords_Click(object sender, EventArgs e) => Response.Redirect("Top10TryIt.aspx");
        protected void btnGoToDownload_Click(object sender, EventArgs e) => Response.Redirect("WebDownloadTryIt.aspx");
        protected void btnGoToPassword_Click(object sender, EventArgs e) => Response.Redirect("PasswordStrengthTryIt.aspx");
    }
}
