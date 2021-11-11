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
            try
            {
                if(Session["Role"] == null)
                {
                    btnUserLogin.Visible = true;
                    btnSignUp.Visible = true;

                    btnLogOut.Visible = false;
                    btnHelloUser.Visible = false;

                    btnAdminLogin.Visible = true;
                    btnAuthorManagement.Visible = false;
                    btnPublisherManagement.Visible = false;
                    btnBookInventory.Visible = false;
                    btnBookIssuing.Visible = false;
                    btnMemberManagement.Visible = false;
                }
                else if(Session["Role"].ToString() == "User")
                {
                    btnUserLogin.Visible = false;
                    btnSignUp.Visible = false;

                    btnLogOut.Visible = true;
                    btnHelloUser.Visible = true;
                    btnHelloUser.Text = "Hello " + Session["FullName"];

                    btnAdminLogin.Visible = true;
                    btnAuthorManagement.Visible = false;
                    btnPublisherManagement.Visible = false;
                    btnBookInventory.Visible = false;
                    btnBookIssuing.Visible = false;
                    btnMemberManagement.Visible = false;
                }
                else if(Session["Role"].ToString() == "Admin")
                {
                    btnUserLogin.Visible = false;
                    btnSignUp.Visible = false;

                    btnLogOut.Visible = true;
                    btnHelloUser.Visible = true;
                    btnHelloUser.Text = "Hello Admin";

                    btnAdminLogin.Visible = false;
                    btnAuthorManagement.Visible = true;
                    btnPublisherManagement.Visible = true;
                    btnBookInventory.Visible = true;
                    btnBookIssuing.Visible = true;
                    btnMemberManagement.Visible = true;
                }


            }
            catch(Exception ex)
            {
                throw ex;
            }

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
            //Response.Redirect("UserLogin.aspx");
        }

        protected void SignUp(object sender, EventArgs e)
        {
            Response.Redirect("UserPages/UserSignUp.aspx");


        }

        //on pressin logout button in all pages since site1.master visible in all pages wherever it's linked
        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            //making session vars empty when pressed on logout in userlogin and adminlogin page
            Session["FullName"] = "";
            Session["MemberID"] = "";
            Session["Password"] = "";
            Session["Role"] = "";
            Session["Status"] = "";

            //setting to default view that is in above if condition when role == "".
            btnUserLogin.Visible = true;
            btnSignUp.Visible = true;

            btnLogOut.Visible = false;
            btnHelloUser.Visible = false;

            btnAdminLogin.Visible = true;
            btnAuthorManagement.Visible = false;
            btnPublisherManagement.Visible = false;
            btnBookInventory.Visible = false;
            btnBookIssuing.Visible = false;
            btnMemberManagement.Visible = false;
        }


        //protected void HelloUser(object sender, EventArgs e)
        //{
        //    Response.Redirect("UserPages/AdminLogin.aspx");
        //}



    }
}