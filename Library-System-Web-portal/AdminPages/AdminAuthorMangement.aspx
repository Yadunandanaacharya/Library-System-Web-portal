<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminAuthorMangement.aspx.cs" Inherits="Library_System_Web_portal.AdminAuthorMangement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


      <div class="container">

        <div class="row">

            <div class="col-md-5">

                <div class="card">

                    <div class="card-body">
                       
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Author Details</h4>
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
                                <label>Author ID</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <asp:TextBox ID="TextBox13" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:Button ID="Button1234" CssClass="btn btn-primary" runat="server" Text="Go"></asp:Button>
                                     </div>
                                 </div>
                            </div>

                            <div class="col-md-9">
                                <label>Author Name</label>
                                 <div class="form-group">
                                    <asp:TextBox ID="TextBox2333" CssClass="form-control" runat="server" placeholder="Author Name"
                                       ></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <br />

                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-4">
                                <asp:Button CssClass="btn btn-success w-100" ID="Button1" runat="server" Text="Add" />
                                </div>

                            <div class="col-4">
                                <asp:Button CssClass="btn btn-warning w-100" ID="Button2" runat="server" Text="Update" />
                            </div>
                            
                            <div class="col-4">
                                <asp:Button CssClass="btn btn-danger w-100" ID="Button3" runat="server" Text="Delete" />
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
