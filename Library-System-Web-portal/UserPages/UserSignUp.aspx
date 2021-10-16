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
                                    <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server" placeholder="Full Name"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtDOB" CssClass="form-control" runat="server" placeholder="Date of Birth"
                                        TextMode="Date"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Contact Number</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtContactNumber" CssClass="form-control" runat="server" placeholder="Contact Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Email</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email"
                                        TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                 <div class="form-group">
                                     <asp:DropDownList CssClass="form-control" ID="dropDownListState" runat="server">
                                         <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                                                <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="Andhra Pradesh" Value="Andhra Pradesh" />
                              <asp:ListItem Text="Arunachal Pradesh" Value="Arunachal Pradesh" />
                              <asp:ListItem Text="Assam" Value="Assam" />
                              <asp:ListItem Text="Bihar" Value="Bihar" />
                              <asp:ListItem Text="Chhattisgarh" Value="Chhattisgarh" />
                              <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                              <asp:ListItem Text="Goa" Value="Goa" />
                              <asp:ListItem Text="Gujarat" Value="Gujarat" />
                              <asp:ListItem Text="Haryana" Value="Haryana" />
                              <asp:ListItem Text="Himachal Pradesh" Value="Himachal Pradesh" />
                              <asp:ListItem Text="Jammu and Kashmir" Value="Jammu and Kashmir" />
                              <asp:ListItem Text="Jharkhand" Value="Jharkhand" />
                              <asp:ListItem Text="Karnataka" Value="Karnataka" />
                              <asp:ListItem Text="Kerala" Value="Kerala" />
                              <asp:ListItem Text="Madhya Pradesh" Value="Madhya Pradesh" />
                              <asp:ListItem Text="Maharashtra" Value="Maharashtra" />
                              <asp:ListItem Text="Manipur" Value="Manipur" />
                              <asp:ListItem Text="Meghalaya" Value="Meghalaya" />
                              <asp:ListItem Text="Mizoram" Value="Mizoram" />
                              <asp:ListItem Text="Nagaland" Value="Nagaland" />
                              <asp:ListItem Text="Odisha" Value="Odisha" />
                              <asp:ListItem Text="Punjab" Value="Punjab" />
                              <asp:ListItem Text="Rajasthan" Value="Rajasthan" />
                              <asp:ListItem Text="Sikkim" Value="Sikkim" />
                              <asp:ListItem Text="Tamil Nadu" Value="Tamil Nadu" />
                              <asp:ListItem Text="Telangana" Value="Telangana" />
                              <asp:ListItem Text="Tripura" Value="Tripura" />
                              <asp:ListItem Text="Uttar Pradesh" Value="Uttar Pradesh" />
                              <asp:ListItem Text="Uttarakhand" Value="Uttarakhand" />
                              <asp:ListItem Text="West Bengal" Value="West Bengal" />
                                     </asp:DropDownList>
                                 </div>
                            </div>

                            <div class="col-md-4">
                                <label>City</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtBoxCity" CssClass="form-control" runat="server" placeholder="City"
                                        ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pin code</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtBoxPinCode" CssClass="form-control" runat="server" placeholder="Pin code"
                                        TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtBoxFullAddress" CssClass="form-control" runat="server" placeholder="Full Address"
                                        TextMode="MultiLine" Rows="2"></asp:TextBox>
                                </div>
                            </div>
                            
                        </div>

                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col">
                                <center>
                                <span class="badge rounded-pill bg-primary">Login Credentials</span>
                                </center>
                            </div>
                        </div>
                        
                        <div class="row">
                            <div class="col-md-6">
                                <label>Member ID</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtBoxMemberID" CssClass="form-control" runat="server" placeholder="Member ID"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Password</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtBoxPassword" CssClass="form-control" runat="server" placeholder="Password"
                                        TextMode="Password"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <label>Sign Up</label>
                                 <div class="form-group">
                                    <asp:Button ID="txtBoxSignUp" CssClass="btn btn-primary w-100 btn-lg" runat="server" placeholder="Sign Up"
                                        Text="Sign Up">

                                    </asp:Button>
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
