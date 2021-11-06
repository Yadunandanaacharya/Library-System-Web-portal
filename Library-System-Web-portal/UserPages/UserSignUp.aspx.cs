using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_System_Web_portal
{
    public partial class UserSignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string webServicePath = ConfigurationManager.AppSettings["WebServicePath"].ToString().TrimEnd('/');

            UserControls.PagerData pagerData = new UserControls.PagerData();
            pagerData.ServicePath = webServicePath;

            Page.ClientScript.RegisterStartupScript(GetType(), "InitialLoadMethod", "InitialLoadMethod(" + (new JavaScriptSerializer()).Serialize(pagerData) + ")",true);
        }
    }
}