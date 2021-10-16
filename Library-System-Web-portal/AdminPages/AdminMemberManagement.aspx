<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMemberManagement.aspx.cs" Inherits="Library_System_Web_portal.AdminPages.AdminMemberManagement" %>
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
                                    <h4>Member Details</h4>
                                </center>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <center>
                                    <img width="90px" src="../Images/userlogin.jfif"
                                        />
                                </center>
                            </div>
                        </div>


                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>

                        <div class="row">

                            <div class="col-md-3">
                                <label>Member ID</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <asp:TextBox ID="txtMemberID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:LinkButton ID="lnkButtonRight" Class="btn btn-primary" runat="server" Text="s">
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>
                                     </div>
                                 </div>
                            </div>

                            <div class="col-md-4">
                                <label>Full Name</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server" placeholder="Full Name"
                                       ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-5">
                                <label>Account Status</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                         
                                        <asp:TextBox ID="txtAccountStatus" CssClass="form-control ms-1" runat="server" placeholder="Account Status"
                                            ReadOnly="True"></asp:TextBox>
                                         
                                         <asp:LinkButton ID="lnkButtonRight2" Class="btn btn-success ms-1" runat="server" Text="s">
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>
                                         <%-- s-save --%>

                                            <asp:LinkButton ID="lnkButtonRightP" Class="btn btn-warning ms-1" runat="server" Text="p">
                                             <i class="fa fa-pause-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>
                                         <%-- p=pending --%>

                                         <asp:LinkButton ID="lnkButtonRightD" Class="btn btn-danger ms-1" runat="server" Text="d">
                                             <i class="fa fa-times-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>
                                    <%-- d=deactivate --%>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />
                        <div class="row">
                            
                            <div class="col-md-4">
                                <label>DOB</label>
                                <asp:TextBox ID="txtDOB" runat="server" placeholder="DOB"  ReadOnly="True" TextMode="Date"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                            <label>Contact NO</label>
                                <asp:TextBox ID="txtContactNO" runat="server" placeholder="Contact NO" ReadOnly="True"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                            <label>Email ID</label>
                                <asp:TextBox ID="txtEmailID" runat="server" placeholder="Email ID" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>
                        <br />

                         <div class="row">
                            
                            <div class="col-md-4">
                                <label>State</label>
                                <asp:TextBox ID="txtState" runat="server" placeholder="State"  ReadOnly="True" ></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                            <label>City</label>
                                <asp:TextBox ID="txtCity" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                            <label>Pin code</label>
                                <asp:TextBox ID="txtPinCode" runat="server" placeholder="Pin code" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>

                        <br />

                        <div class="row">
                            
                            <div class="col-12">
                                <div class="form-group">
                                     
                                <label>Full Postal Address</label>
                                <asp:TextBox ID="txtFullPostalAddress" class="form-control" runat="server" placeholder="Full Postal Address"  ReadOnly="True" 
                                    TextMode="MultiLine"></asp:TextBox>

                                </div>
                            </div>

                           
                        </div>

                        <br />
                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-8 mx-auto">
                                <asp:Button CssClass="btn btn-danger w-100" ID="btnDeleteUser" runat="server" Text="Delete User Permanently" />
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
                                    <h4>Member List</h4>
                                    <span></span>
                                </center>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <asp:GridView class="table table-striped table-bordered" ID="gridViewMemberList" runat="server"></asp:GridView>
                                </div>
                            </div>

                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>



</asp:Content>
