<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminPublisherMangement.aspx.cs" Inherits="Library_System_Web_portal.AdminPublisherMangement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <script src="../Scripts/PublisherManage.js"></script>
    <div class="container">

        <div class="row">

            <div class="col-md-5">

                <div class="card">

                    <div class="card-body">
                       
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Publisher Details</h4>
                                </center>
                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <center>
                                <img width="90px" src="Images/Pulisher.png" />
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
                                <label>Publisher ID</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                        <%--<asp:TextBox ID="txtPublisherID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>--%>
                                        <%--<asp:Button ID="btnGo" onclick="CheckPublisher(); return false;" CssClass="btn btn-primary" runat="server" Text="Go"></asp:Button>--%>
                                            <input type="text" id="txtPublisherID" class="form-control"   placeholder="ID" >
                                
                                         <button id="btnGo" onclick="CheckPublisher(); return false;"  Class="btn btn-primary" runat="server" >Go</button>
                                     
                                     </div>
                                 </div>
                            </div>

                            <div class="col-md-9">
                                <label>Publisher Name</label>
                                 <div class="form-group">
                                   <%-- <asp:TextBox ID="txtPublisherName" CssClass="form-control" runat="server" placeholder="Publisher Name"
                                       ></asp:TextBox>--%>
                                     <input type="text" id="txtPublisherName" class="form-control"   placeholder="Author Name" >
                                </div>
                            </div>
                        </div>

                        <br />

                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-4">
                                <%--<asp:Button CssClass="btn btn-success w-100" ID="btnAdd" runat="server" Text="Add" />--%>
                                <button id="btnAdd" class="btn btn-success w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="InsertPublisherDetails(); return false;" enableviewstate="false">
                                         Add</button>
                                </div>

                            <div class="col-4">
                                <%--<asp:Button CssClass="btn btn-warning w-100" ID="btnUpdate" runat="server" Text="Update" />--%>
                                <button id="btnUpdate" class="btn btn-warning w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="UpdatePublisher(); return false;" enableviewstate="false">
                                         Update</button>
                            </div>
                            
                            <div class="col-4">
                                <%--<asp:Button CssClass="btn btn-danger w-100" ID="btnDelete" runat="server" Text="Delete" />--%>
                                <button id="btnDelete" class="btn btn-danger w-100" runat="server" placeholder="Add" Text="Add"
                                         onclick="DeletePublisher(); return false;" enableviewstate="false">
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
                                    <h4>Publisher List</h4>
                                    <span></span>
                                </center>
                            </div>

                           <div class="row">
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <input type="text" id="txtSearch" class="form-control" placeholder="Search">
                                            <button id="btnSearch" onclick="SearchPublisher(); return false;" class="btn btn-primary" runat="server">Search</button>
                                        </div>
                                    </div>
                                </div>
                                <div class="col-md-5">
                                    <button id="btnShowAll"  onclick="ShowAllData(); return false;" class="btn btn-primary" runat="server">Show All</button>
                                </div>
                            </div>

                            <div class="row">
                                <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>--%>
                                <div class="col">
                                    <table id="dataTable" class="table table-striped table-bordered table-sm" cellspacing="0" width="100%">
                                        <thead>
                                            <tr>
                                                <th>Publisher ID</th>
                                                <th>Publisher Name</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tBody" data-bind="foreach: FeatureObjectList" class="tbodypositionfixed">
                                            <%--here tbody i'm using in jquery code to render data into it table's body--%>
                                            <tr>
                                                <td>l2</td>
                                                <td>Sham</td>
                                            </tr> 
                                        </tbody>
                                    </table>

                                    <%--for pagination--%>

                                    <%--<div id="listingTable"></div>
                                    <a href="javascript:prevPage()" id="btn_prev">Prev</a>
                                    <a href="javascript:nextPage()" id="btn_next">Next</a>
                                    page: <span id="page"></span>--%>

                                    <nav aria-label="Page navigation example">
                                        <ul class="pagination">
                                            <li class="page-item"><a class="page-link" href="javascript:PrevPageIs()" id="btn_prev">Previous</a></li>
                                           <%-- <li class="page-item"><a class="page-link" href="#">1</a></li>
                                            <li class="page-item"><a class="page-link" href="#">2</a></li>
                                            <li class="page-item"><a class="page-link" href="#">3</a></li>--%>
                                            <li class="page-item"><a class="page-link" href="javascript:NextPageIs()" id="btn_next">Next</a></li>
                                        </ul>
                                    </nav>
                                </div>
                                </div>


                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
