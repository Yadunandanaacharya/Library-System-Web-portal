<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminBookIssuing.aspx.cs" Inherits="Library_System_Web_portal.AdminBookIssuing1" %>
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
                                    <h4>Book Issuing</h4>
                                </center>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <center>
                                    <img width="90px" src="../Images/Books.jfif"
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
                            
                            <div class="col-md-6">
                                <label>Member ID</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtMemberID" CssClass="form-control" runat="server" placeholder="Member ID"
                                       ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Book ID</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <asp:TextBox ID="txtBookID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button ID="btnBookID" CssClass="btn btn-primary" runat="server" Text="Go"></asp:Button>
                                     </div>
                                 </div>
                            </div>

                        </div>

                         <div class="row">
                            
                            <div class="col-md-6">
                                <label>Member Name</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtMemberName" CssClass="form-control" runat="server" placeholder="Member Name"
                                       ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Book Name</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <asp:TextBox ID="txtBookName" CssClass="form-control" runat="server" placeholder="Book Name" ReadOnly="True"></asp:TextBox>
                                     </div>
                                 </div>
                            </div>

                        </div>

                         <div class="row">
                            
                            <div class="col-md-6">
                                <label>Start Date</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="txtStartDate" CssClass="form-control" runat="server" placeholder="Start Date"
                                     TextMode="Date"  ></asp:TextBox>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>End Date</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <asp:TextBox ID="txtEndDate" CssClass="form-control" runat="server" placeholder="End Date"
                                         TextMode="Date"   ></asp:TextBox>
                                     </div>
                                 </div>
                            </div>

                        </div>

                        <br />

                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-6">
                                <asp:Button CssClass="btn btn-primary w-100" ID="btnIssue" 
                                    runat="server" Text="Issue" />
                            </div>
                            
                            <div class="col-6">
                                <asp:Button CssClass="btn btn-danger w-100" ID="btnReturn" 
                                    runat="server" Text="Return" />
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
                                    <h4>Author List</h4>
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
                                    <asp:GridView class="table table-striped table-bordered" ID="gridViewAuthorList" runat="server"></asp:GridView>
                                </div>
                            </div>

                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
