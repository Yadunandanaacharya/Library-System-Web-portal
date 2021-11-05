using Library_System_Web_portal.LibraryService;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Library_System_Web_portal_Service;
using Library_System_Web_portal_Service.Library;

namespace Library_System_Web_portal
{
    public partial class AdminLogin1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //user login
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var memberID = txtAdminID.Text.Trim();
            var passWord = txtPassword.Text.Trim();

            Library_System_Web_portal_Service.Library.LoginInfo loginInfo = new Library_System_Web_portal_Service.Library.LoginInfo();

            loginInfo = LogInInfo.GetCurrentAdminInfo(memberID, passWord);

            if (loginInfo.Count > 0)
            {
                Session["FullName"] = loginInfo.FullName;
                Session["MemberID"] = loginInfo.MemberID;
                Session["Password"] = loginInfo.Password;
                Session["Role"] = "Admin";

                Response.Redirect("HomePage.aspx");
            }
            else if (loginInfo.Count == 0)
            {
                Response.Write("<script>alert('Invalid credentials');</script>");
            }

            Response.Write("<script>alert('loginInfo');</script>");


        }

    }
}