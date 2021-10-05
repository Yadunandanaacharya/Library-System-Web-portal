using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library_System_Web_portal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void AdminLogin(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminLogin.aspx");
        }

        protected void AuthorManage(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminAuthorMangement.aspx");
        }

        protected void PublisherManage(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminPublisherMangement.aspx");
        }

        protected void BookInventory(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminBookInventory.aspx");
        }

        protected void BookIssuing(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminBookIssuing.aspx");
        }

        protected void MemberManagement(object sender, EventArgs e)
        {
            Response.Redirect("AdminPages/AdminMemberManagement.aspx");
        }

        //protected void ViewBooks(object sender, EventArgs e)
        //{
        //    Response.Redirect("AdminPages/AdminLogin.aspx");
        //}

        protected void UserLogin(object sender, EventArgs e)
        {
            Response.Redirect("UserPages/UserLogin.aspx");
        }

        protected void SignUp(object sender, EventArgs e)
        {
            Response.Redirect("UserPages/UserSignUp.aspx");
        }

       
        //protected void HelloUser(object sender, EventArgs e)
        //{
        //    Response.Redirect("UserPages/AdminLogin.aspx");
        //}

        

    }
}