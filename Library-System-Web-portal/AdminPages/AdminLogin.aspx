<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="Library_System_Web_portal.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150px" src="Images/userlogin.jfif" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Admin  Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row d-grid gap-2">
                            <div class="col">
                               <div class="d-grid gap-2">
                                    <label>Admin ID</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtAdminID" CssClass="form-control" runat="server" placeholder="Admin ID"></asp:TextBox>
                                </div>

                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="txtPassword" CssClass="form-control" runat="server" placeholder="Password"
                                        TextMode="Password" OnClick="btnLogin_Click"></asp:TextBox>

                                </div>
                                    <div class="form-group">
                                        <%--<asp:Button ID="btnLogin" class="btn btn-primary w-100 btn-lg" runat="server" Text="Login" />--%>
                                      <%--  <asp:LinkButton ID="btnLogin" CssClass="btn btn-primary w-100 btn-lg" runat="server" Text="Login"
                                       OnClick="btnLogin_Click"></asp:LinkButton>--%>

                                   <asp:LinkButton ID="LinkButton1" CssClass="btn btn-primary w-100 btn-lg" runat="server" OnClick="btnLogin_Click">Login</asp:LinkButton>

                                    </div>
                                    

                                     
                                </div>
                            </div>
                        </div>


                    </div>
                </div>

                <a href="HomePage.aspx"><< Back to Home</a>
                <br />
                <br />
            </div>
        </div>
    </div>

</asp:Content>
