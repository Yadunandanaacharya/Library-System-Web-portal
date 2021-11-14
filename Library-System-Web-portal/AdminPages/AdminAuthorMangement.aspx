<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminAuthorMangement.aspx.cs" Inherits="Library_System_Web_portal.AdminAuthorMangement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--some time jquery is not loaded error i'll get so put all these 3 if you only put jquery then you get bootstrap--%> 

    <%--<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.3/umd/popper.min.js" integrity="sha384-vFJXuSJphROIrBnz7yo7oB41mKfc8JzQZiCq4NCceLEaO4IHwicKwpJf9c9IpFgh" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/js/bootstrap.min.js" integrity="sha384-alpBpkh1PFOepccYVYDB4do5UnbKysX5WZXm3XxPqe5iKTfUKjNkCk9SaVuEZflJ" crossorigin="anonymous"></script>
--%>

    <%--<link rel="stylesheet" type="text/css" href="https://cdn.datatables.net/1.11.3/css/jquery.dataTables.css">
  
    <script type="text/javascript" charset="utf8" src="https://cdn.datatables.net/1.11.3/js/jquery.dataTables.js"></script>--%>


     <script type="text/javascript" src="../Scripts/AdminAuthorManage.js" ></script>

    <style>
        table {
            font-family: arial, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

        td, th {
            border: 1px solid #dddddd;
            text-align: left;
            padding: 8px;
        }

        tr:nth-child(even) {
            background-color: #dddddd;
        }
    </style>

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

                            <div class="col-md-4">
                                <label>Author ID</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <%--<asp:TextBox ID="txtAuthorID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>--%>
                                        <input type="text" id="txtAuthorID" class="form-control"   placeholder="ID" >
                                
                                         <button id="btnGo" onclick="CheckAuthor(); return false;"  Class="btn btn-primary" runat="server" >Go</button>
                                     </div>
                                 </div>
                            </div>

                            <div class="col-md-8">
                                <label>Author Name</label>
                                 <div class="form-group">
                                   <%-- <asp:TextBox ID="txtAuthorName" CssClass="form-control" runat="server" placeholder="Author Name"
                                       ></asp:TextBox>--%>
                                     <input type="text" id="txtAuthorName" class="form-control"   placeholder="Author Name" >
                                
                                </div>
                            </div>

                        </div>

                        <br />

                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-4">
                                <%--<input type="button" class="btn btn-success w-100" id="btnAdd" runat="server" text="Add" />--%>
                                <button id="btnAdd" class="btn btn-success w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="InsertAuthorDetails(); return false;" enableviewstate="false">
                                         Add</button>
                                </div>

                            <div class="col-4">
                                <%--<asp:Button CssClass="btn btn-warning w-100" ID="btnUpdate" runat="server" Text="Update" />--%>
                                <button id="btnUpdate" class="btn btn-warning w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="UpdateAuthor(); return false;" enableviewstate="false">
                                         Update</button>
                            </div>
                            
                            <div class="col-4">
                                <%--<asp:Button CssClass="btn btn-danger w-100" ID="btnDelete" runat="server" Text="Delete" />--%>
                                <button id="btnDelete" class="btn btn-danger w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="DeleteAuthor(); return false;" enableviewstate="false">
                                         Delete</button>
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
                                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>
                                <div class="col">
                                    <table id="dataTable" class="table table-striped table-bordered table-sm" cellspacing="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th>Author ID</th>
                                                <th>Author Name</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tBody">
                                            <%--here tbody i'm using in jquery code to render data into it table's body--%>
                                            <%--<tr>
                                                <td>l2</td>
                                                <td>Sham</td>
                                            </tr> --%>
                                        </tbody>
                                    </table>


                                </div>



                                <%--<gridview class="table table-striped table-bordered" id="GridView2"
                                        ></gridview>--%>
                                    <%--<asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>--%>
                                </div>
                            </div>

                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
