<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="Library_System_Web_portal.UserSignUp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="90px" src="Images/userlogin.jfif" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>User SignUp</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Full Name</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox13" CssClass="form-control" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox2333" CssClass="form-control" runat="server" placeholder="Date of Birth"
                                        TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row d-grid gap-2">
                            <div class="col">
                               <div class="d-grid gap-2">
                                 <label>Admin ID</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Admin ID"></asp:TextBox>
                                </div>

                                <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" placeholder="Password"
                                        TextMode="Password"></asp:TextBox>
                                </div>
                                
                                    <div class="form-group">
                                        <asp:Button ID="Button1" class="btn btn-primary w-100 btn-lg" runat="server" Text="Login" />
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
