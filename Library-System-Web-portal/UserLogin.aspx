<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="Library_System_Web_portal.UserLogin1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="Scripts/UserSignUpDetails.js"></script>
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
                                    <h3>Member Login</h3>
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
                                    <label>Member ID</label>
                                 <div class="form-group">
                                    <input type="text" id="txtMemberID" class="form-control" placeholder="Full Name" >
                                
                                 </div>

                                <label>Password</label>
                                <div class="form-group">
                                    
                               <input type="text" id="txtPassword" class="form-control" placeholder="Password" >
                                
                                    </div>
                                
                                    <div class="form-group">
                                        <input id="btnLogIn" class="btn btn-primary w-100 btn-lg" type="button" value="Login" onclick="CheckUserExists(); " />
                                    </div>
                                    

                                     <div class="form-group">
                                       <a href="UserSignUp.aspx"> 
                                           <input id="btnSignUp" class="btn btn-info w-100 btn-lg" type="button" value="SignUp" />
                                        </a>
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
