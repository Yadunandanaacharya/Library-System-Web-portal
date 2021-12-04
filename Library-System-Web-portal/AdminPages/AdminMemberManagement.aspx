<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminMemberManagement.aspx.cs" Inherits="Library_System_Web_portal.AdminPages.AdminMemberManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script src="../Scripts/MemberManage.js"></script>
    
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
                                        <%--<asp:TextBox ID="txtMemberID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>--%>
                                       <%-- <asp:LinkButton ID="lnkButtonRight" Class="btn btn-primary" runat="server" Text="s">
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>--%>

                                         <input type="text" id="txtMemberID" class="form-control"   placeholder="ID" >
                                
                                         <button id="btnRight" onclick="CheckMember(); return false;"  Class="btn btn-primary" runat="server" >
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i>
                                         </button>
                                     </div>
                                 </div>
                            </div>

                            <div class="col-md-4">
                                <label>Full Name</label>
                                 <div class="form-group">
                                   <%-- <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server" placeholder="Full Name"
                                       ReadOnly="True"></asp:TextBox>--%>
                                     <input type="text" id="txtFullName" class="form-control"   placeholder="Full Name" readonly>
                                </div>
                            </div>

                            <div class="col-md-5">
                                <label>Account Status</label>
                                 <div class="form-group">
                                     <div class="input-group">
                                         
                                        <%--<asp:TextBox ID="txtAccountStatus" CssClass="form-control ms-1" runat="server" placeholder="Account Status"
                                            ReadOnly="True"></asp:TextBox>--%>
                                         <input type="text" id="txtAccountStatus" class="form-control"   placeholder="Account Status" readonly>
                                         
                                         <%--<asp:LinkButton ID="lnkButtonRight2" Class="btn btn-success ms-1" runat="server" Text="s">
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>--%>
                                         <button id="btnActivate" onclick="ActivateMember();return false;"  Class="btn btn-success ms-1" runat="server" value="A" >
                                             <i class="fa fa-check-circle-o" id="iconCircle" aria-hidden="true"></i>
                                         </button>
                                         <%-- s-save --%>

                                            <%--<asp:LinkButton ID="lnkButtonRightP" Class="btn btn-warning ms-1" runat="server" Text="p">
                                             <i class="fa fa-pause-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>--%>
                                         <button id="btnDeactivate" onclick="DeActivateMember();return false;"  Class="btn btn-warning ms-1" runat="server" value="I">
                                             <i class="fa fa-pause-circle-o" aria-hidden="true"></i>
                                         </button>
                                         <%-- p=pending --%>

                                         <%--<asp:LinkButton ID="lnkButtonRightD" Class="btn btn-danger ms-1" runat="server" Text="d">
                                             <i class="fa fa-times-circle-o" aria-hidden="true"></i>
                                         </asp:LinkButton>--%>
                                         <button id="btnDeletePermanent" onclick="DeleteMember();return false;" Class="btn btn-danger ms-1" runat="server" value="D">
                                             <i class="fa fa-times-circle-o" aria-hidden="true"></i>
                                         </button>
                                    <%-- d=deactivate --%>
                                    </div>
                                </div>
                            </div>

                        </div>

                        <br />
                        <div class="row">
                            
                            <div class="col-md-4">
                                <label>DOB</label>
                                <%--<asp:TextBox ID="txtDOB" runat="server" placeholder="DOB"  ReadOnly="True" TextMode="Date"></asp:TextBox>--%>
                                <input type="text" id="txtDOB" class="form-control"   placeholder="DOB" readonly>
                                         
                            </div>

                            <div class="col-md-4">
                            <label>Contact NO</label>
                                <%--<asp:TextBox ID="txtContactNO" runat="server" placeholder="Contact NO" ReadOnly="True"></asp:TextBox>--%>
                                <input type="text" id="txtContactNO" class="form-control"   placeholder="Contact NO" readonly>
                                         
                            </div>

                            <div class="col-md-4">
                            <label>Email ID</label>
                                <%--<asp:TextBox ID="txtEmailID" runat="server" placeholder="Email ID" ReadOnly="True"></asp:TextBox>--%>
                                <input type="text" id="txtEmailID" class="form-control"   placeholder="Email ID" readonly>
                                         
                            </div>
                        </div>
                        <br />

                         <div class="row">
                            
                            <div class="col-md-4">
                                <label>State</label>
                                <%--<asp:TextBox ID="txtState" runat="server" placeholder="State"  ReadOnly="True" ></asp:TextBox>--%>
                                <input type="text" id="txtState" class="form-control"   placeholder="State" readonly>
                                         
                            </div>

                            <div class="col-md-4">
                            <label>City</label>
                                <%--<asp:TextBox ID="txtCity" runat="server" placeholder="City" ReadOnly="True"></asp:TextBox>--%>
                                <input type="text" id="txtCity" class="form-control"   placeholder="City" readonly>
                                         
                            </div>

                            <div class="col-md-4">
                            <label>Pin code</label>
                                <%--<asp:TextBox ID="txtPinCode" runat="server" placeholder="Pin code" ReadOnly="True"></asp:TextBox>--%>
                                <input type="text" id="txtPinCode" class="form-control"   placeholder="Pin code" readonly>
                                         
                            </div>
                        </div>

                        <br />

                        <div class="row">
                            
                            <div class="col-12">
                                <div class="form-group">
                                     
                                <label>Full Postal Address</label>
                                <%--<asp:TextBox ID="txtFullPostalAddress" class="form-control" runat="server" placeholder="Full Postal Address"  ReadOnly="True" 
                                    TextMode="MultiLine"></asp:TextBox>--%>
                                    <input type="text" id="txtFullPostalAddress" class="form-control"   placeholder="Full Postal Address" readonly>
                                         

                                </div>
                            </div>

                           
                        </div>

                        <br />
                        <%--below is pill badge--%>
                        <div class="row">
                            <div class="col-8 mx-auto">
                                <%--<asp:Button CssClass="btn btn-danger w-100" ID="btnDeleteUser" runat="server" Text="Delete User Permanently" />--%>
                                <button id="btnDeleteUser" onclick="DeleteMember();return false;"  Class="btn btn-danger w-100" runat="server" value="D">
                                            Delete User Permanently
                                         </button>
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
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <input type="text" id="txtSearch" class="form-control" placeholder="Search" >
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
                                                <th>Member ID</th>
                                                <th>Name</th>
                                                <th>Account Status</th>
                                                <th>Contact</th>
                                                <th>E-mail</th>
                                                <th>State</th>
                                                <th>City</th>
                                            </tr>
                                        </thead>
                                        <tbody id="tBody" data-bind="foreach: FeatureObjectList" class="tbodypositionfixed">
                                            <%--here tbody i'm using in jquery code to render data into it table's body--%>
                                            <tr>
                                                <td>l2</td>
                                                <td>Sham</td>
                                                <td>Sham</td>
                                                <td>Sham</td>
                                                <td>Sham</td>
                                                <td>Sham</td>
                                                <td>Sham</td>
                                            </tr>
                                        </tbody>
                                    </table>

                                    <%--for pagination--%>

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
