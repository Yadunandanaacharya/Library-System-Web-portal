<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserProfile.aspx.cs" Inherits="Library_System_Web_portal.UserProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
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
                                    <h4>Your Profile</h4>
                                    <span>Account Status-</span>
                                        <asp:Label class="badge rounded-pill bg-warning text-dark" runat="server" Text="Your status">
                                        </asp:Label>

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

                        <div class="row">
                            <div class="col-md-6">
                                <label>Contact Number</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox133" CssClass="form-control" runat="server" placeholder="Contact Number"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Email</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox2332" CssClass="form-control" runat="server" placeholder="Email"
                                        TextMode="Email"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                 <div class="form-group">
                                     <asp:DropDownList CssClass="form-control" ID="DropDownList1" runat="server">
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
                                    <asp:TextBox ID="TextBox23632" CssClass="form-control" runat="server" placeholder="City"
                                        ></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pin code</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox236632" CssClass="form-control" runat="server" placeholder="Pin code"
                                        TextMode="Number"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" placeholder="Full Address"
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
                            <div class="col-md-4">
                                <label>User ID</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox23535" CssClass="form-control" runat="server" placeholder="User ID"
                                        ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Password</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox333" CssClass="form-control" runat="server" placeholder="Password"
                                        TextMode="Password" ReadOnly="true"></asp:TextBox>
                                </div>
                            </div>
                                <div class="col-md-4">
                                    <label>New Password</label>
                                     <div class="form-group">
                                        <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" placeholder="New Password"
                                            TextMode="Password"></asp:TextBox>
                                    </div>
                                </div>


                        </div>
                        <br />
                         <div class="row">
                            <div class="col-md-8 mx-auto">
                                <center>
                                 <div class="form-group">
                                    <asp:Button ID="TextBox2" CssClass="btn btn-primary w-100  btn-lg" runat="server" placeholder="Sign Up"
                                        Text="Update">
                                    </asp:Button>
                                </div>
                                     </center>
                            </div>
                        </div>



                    </div>
                </div>

                <a href="HomePage.aspx"><< Back to Home</a>
                <br />
                <br />
            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="90px" src="Images/Books.jfif" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Your Issued Books</h4>
                                    <span></span>
                                        <asp:Label class="badge badge-pill badge-info" runat="server" Text="Info about issued books">
                                        </asp:Label>
                                </center>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">

                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                                </div>
                            </div>


                        </div>
                        


                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
