<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="UserSignUp.aspx.cs" Inherits="Library_System_Web_portal.UserSignUp1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script type="text/javascript" src="../Scripts/UserSignUpDetails.js"></script>
    
    <div class="container">
        <div class="row">
            <div class="col-md-8 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="90px" src="../Images/userlogin.jfif" />

                                </center>
                            </div>
                        </div>
                        <button type="button"  class="btn btn-primary float-right" onclick="javascript:dataInsertSuccessModal();return false;">Add Object<i class=""></i></button>

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
                                     <%--don't addd runat server for input type html you get error--%>
                                     <input type="text" id="txtFullName" class="form-control" placeholder="Full Name" >
                                
                                    <%--<asp:TextBox ID="txtFullName" CssClass="form-control" runat="server" placeholder="Full Name"></asp:TextBox>--%>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Date of Birth</label>
                                 <div class="form-group">
                                     <input  type="date" id="txtDOB" class="form-control" placeholder="Date of Birth" >
                                     
                                  <%--  <asp:TextBox ID="txtDOB" CssClass="form-control" runat="server" placeholder="Date of Birth"
                                        TextMode="Date"></asp:TextBox>--%>
                                     
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-6">
                                <label>Contact Number</label>
                                 <div class="form-group">
                                     <input type="text" id="txtContactNumber" class="form-control"  placeholder="Contact Number" >
                                
                                    <%--<asp:TextBox ID="txtContactNumber" CssClass="form-control" runat="server" placeholder="Contact Number"></asp:TextBox>--%>
                                </div>
                            </div>
                            <div class="col-md-6">
                                <label>Email</label>
                                 <div class="form-group">
                                     <input type="text" id="txtEmail" class="form-control"  placeholder="Email" >
                                

                                     
                                    <%--<asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="Email"
                                        TextMode="Email"></asp:TextBox>--%>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-4">
                                <label>State</label>
                                 <div class="form-group">
                                     <asp:DropDownList CssClass="form-control" ID="dropDownListState" runat="server">
                              <asp:ListItem Text="Select" Value="Select"></asp:ListItem>
                              <asp:ListItem Text="Andhra Pradesh" Value="1" />
                              <asp:ListItem Text="Arunachal Pradesh" Value="2" />
                              <asp:ListItem Text="Assam" Value="3" />
                              <asp:ListItem Text="Bihar" Value="4" />
                              <asp:ListItem Text="Chhattisgarh" Value="5" />
                              <asp:ListItem Text="Rajasthan" Value="6" />
                              <asp:ListItem Text="Goa" Value="7" />
                              <asp:ListItem Text="Gujarat" Value="8" />
                              <asp:ListItem Text="Haryana" Value="9" />
                              <asp:ListItem Text="Himachal Pradesh" Value="10" />
                              <asp:ListItem Text="Jammu and Kashmir" Value="11" />
                              <asp:ListItem Text="Jharkhand" Value="12" />
                              <asp:ListItem Text="Karnataka" Value="13" />
                              <asp:ListItem Text="Kerala" Value="14" />
                              <asp:ListItem Text="Madhya Pradesh" Value="15" />
                              <asp:ListItem Text="Maharashtra" Value="16" />
                              <asp:ListItem Text="Manipur" Value="17" />
                              <asp:ListItem Text="Meghalaya" Value="18" />
                              <asp:ListItem Text="Mizoram" Value="19" />
                              <asp:ListItem Text="Nagaland" Value="20" />
                              <asp:ListItem Text="Odisha" Value="21" />
                              <asp:ListItem Text="Punjab" Value="22" />
                              <asp:ListItem Text="Rajasthan" Value="23" />
                              <asp:ListItem Text="Sikkim" Value="24" />
                              <asp:ListItem Text="Tamil Nadu" Value="25" />
                              <asp:ListItem Text="Telangana" Value="26" />
                              <asp:ListItem Text="Tripura" Value="27" />
                              <asp:ListItem Text="Uttar Pradesh" Value="28" />
                              <asp:ListItem Text="Uttarakhand" Value="29" />
                              <asp:ListItem Text="West Bengal" Value="30" />
                                     </asp:DropDownList>
                                 </div>
                            </div>

                            <div class="col-md-4">
                                <label>City</label>
                                 <div class="form-group">
                                     <input type="text" id="txtBoxCity" class="form-control"  placeholder="City" >
                                
                                     
                                    <%--<asp:TextBox ID="txtBoxCity" CssClass="form-control" runat="server" placeholder="City"
                                        ></asp:TextBox>--%>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <label>Pin code</label>
                                 <div class="form-group">
                                     <input type="text" id="txtBoxPinCode" class="form-control"  placeholder="Pin code" >
                                
                                     
                                    <%--<asp:TextBox ID="txtBoxPinCode" CssClass="form-control" runat="server" placeholder="Pin code"
                                        TextMode="Number"></asp:TextBox>--%>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <label>Full Address</label>
                                 <div class="form-group">
                                     <input type="text" id="txtBoxFullAddress" class="form-control"  placeholder="Full Address" >
                                
                                    
                                    <%--<asp:TextBox ID="txtBoxFullAddress" CssClass="form-control" runat="server" placeholder="Full Address"
                                        TextMode="MultiLine" Rows="2"></asp:TextBox>--%>
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
                                <input type="text" id="txtBoxMemberID" class="form-control"  placeholder="Member ID" >
                                 </div>
                            </div>
                            <div class="col-md-6">
                                <label>Password</label>
                                 <div class="form-group">
                                     <input type="text" id="txtBoxPassword" class="form-control"  placeholder="Password" >
                                
                                     
                                   <%-- <asp:TextBox ID="txtBoxPassword" CssClass="form-control" runat="server" placeholder="Password"
                                        TextMode="Password"></asp:TextBox>--%>
                                </div>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <label>Sign Up</label>
                                 <div class="form-group">
                                   <%-- <asp:Button ID="btnSignUp" onclick="UploadObjectInfo(); return false;" CssClass="btn btn-primary w-100 btn-lg" runat="server" placeholder="Sign Up"
                                        Text="Sign Up">
                                    </asp:Button>--%>
                                     <button id="btnSignUp" class="btn btn-primary w-100 btn-lg" runat="server" placeholder="Sign Up" Text="Sign Up"
                                         onclick="InsertUserSignUpDetails(); return false;" enableviewstate="false">
                                         Sign Up</button>

                                     <%--test  InsertUserSignUpDetails--%>
                                </div>
                            </div>
                        </div>

                        <div class="modal fade" id="dataInserted" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">Modal title</h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">
                                        ...
                                    </div>
                                    <div class="modal-footer">
                                        <button type="button" class="btn btn-secondary" data-dismiss="modal">Close</button>
                                        <button type="button" class="btn btn-primary">Save changes</button>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="modal cust" id="divDataInsertedModal" data-backdrop="static" data-keyboard="false">
                            <div class="modal-dialog modal-lg modal-top-custom">
                                <div class="modal-content">
                                    <!-- Modal Header -->
                                    <div class="modal-header">
                                        <p class="modal-title" style="color: #4C96F9" id="formTitleForValuationClassModal">Data Inserted Successfully...


                                        </p>
                                        <button type="button" class="close" data-dismiss="modal">
                                            <span class="text" id="modalClose" onclick="Clear(); return false;">Close</span>&times;
                                        </button>
                                        <p style="color: #4C96F9"></p>
                                    </div>
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
