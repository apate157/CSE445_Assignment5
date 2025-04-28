<%@ Application Language="C#" Inherits="System.Web.HttpApplication" %>
<script runat="server">

    void Session_Start(object sender, EventArgs e)
    {
        // Store session start time
        Session["StartTime"] = DateTime.Now;
    }

</script>
