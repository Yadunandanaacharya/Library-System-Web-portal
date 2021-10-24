<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AdminBookInventory.aspx.cs" Inherits="Library_System_Web_portal.AdminBookInventory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">

        <div class="row">

            <div class="col-md-4">

                <div class="card">

                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Book Details</h4>
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
                            <div class="col">
                                <asp:FileUpload CssClass="form-control" ID="FileUpload1" runat="server" />
                            </div>
                        </div>

                        <div class="row">

                            <div class="col-md-4">
                                <label>Book ID</label>
                                <div class="form-group">
                                    <div class="input-group">
                                        <asp:TextBox ID="txtBookID" CssClass="form-control" runat="server" placeholder="ID"></asp:TextBox>
                                        <asp:LinkButton ID="lnkBtn" Class="btn btn-primary" runat="server" >
                                             <i class="fa fa-check-circle-o" aria-hidden="true"></i> 
                                            <%--above is font awesome styling--%>
                                        </asp:LinkButton>
                                    </div>
                                </div>
                            </div>

                            <div class="col-md-8">
                                <label>Book Name</label>
                                <div class="form-group">
                                    <asp:TextBox ID="txtFullName" CssClass="form-control" runat="server" placeholder="Full Name"
                                        ReadOnly="True"></asp:TextBox>
                                </div>
                            </div>

                        </div>

                        <br />
                        <div class="row">

                            <div class="col-md-4">
                                <label>Language</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="dropDownListLanguage" runat="server">
                                        <asp:ListItem Text="English" Value="English"></asp:ListItem>
                                        <asp:ListItem Text="German" Value="German"></asp:ListItem>
                                        <asp:ListItem Text="Tulu" Value="Tulu"></asp:ListItem>
                                        <asp:ListItem Text="Kannada" Value="Kannada"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                                <label>Publisher Name</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="dropDownListPublisherName" runat="server">
                                        <asp:ListItem Text="Publisher 1" Value="Publisher 1"></asp:ListItem>
                                        <asp:ListItem Text="Publisher 2" Value="Publisher 2"></asp:ListItem>
                                       </asp:DropDownList>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <label>Author Name</label>
                                <div class="form-group">
                                    <asp:DropDownList ID="dropDownListAuthorName" runat="server">
                                        <asp:ListItem Text="Chetan Bhagath" Value="Chetan Bhagath"></asp:ListItem>
                                        <asp:ListItem Text="Swami Vivekananda" Value="Vivekananda"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                                <br />
                                <label>Publisher Date</label>
                                <asp:TextBox ID="txtPublisherDate" Text="Publisher Date" runat="server" TextMode="Date"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <label>Genres</label>
                                <div class="form-group">
                                    <asp:ListBox ID="listBoxGenres" runat="server">
                                        <asp:ListItem Text="Action" Value="Action" />
                                        <asp:ListItem Text="Adventure" Value="Adventure" />
                                        <asp:ListItem Text="Comic Book" Value="Comic Book" />
                                        <asp:ListItem Text="Self Help" Value="Self Help" />
                                        <asp:ListItem Text="Motivation" Value="Motivation" />
                                        <asp:ListItem Text="Healthy Living" Value="Healthy Living" />
                                        <asp:ListItem Text="Wellness" Value="Wellness" />
                                        <asp:ListItem Text="Crime" Value="Crime" />
                                        <asp:ListItem Text="Drama" Value="Drama" />
                                        <asp:ListItem Text="Fantasy" Value="Fantasy" />
                                        <asp:ListItem Text="Horror" Value="Horror" />
                                        <asp:ListItem Text="Poetry" Value="Poetry" />
                                    </asp:ListBox>
                                </div>
                            </div>
                        </div>
                        <br />

                        <div class="row">

                            <div class="col-md-4">
                                <label>Edition</label>
                                <asp:TextBox ID="txtEdition" runat="server" placeholder="Edition" ></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <label>Book Cost(per unit)</label>
                                <asp:TextBox ID="txtBookCost" runat="server" TextMode="Number" placeholder="City" ></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <label>Pages</label>
                                <asp:TextBox ID="txtPages" runat="server" TextMode="Number" placeholder="Pages" ></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="row">

                            <div class="col-md-4">
                                <label>Actual Stock</label>
                                <asp:TextBox ID="txtActualStock" runat="server" TextMode="Number" placeholder="Actual Stock" ></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <label>Current Stock</label>
                                <asp:TextBox ID="txtCurrentStock" runat="server" placeholder="Current Stock" ReadOnly="True"></asp:TextBox>
                            </div>

                            <div class="col-md-4">
                                <label>Issued Books</label>
                                <asp:TextBox ID="txtIssuedBooks" runat="server" placeholder="Issued Books" ReadOnly="True"></asp:TextBox>
                            </div>
                        </div>

                        <br />

                        <div class="row">

                            <div class="col-12">
                                <div class="form-group">

                                    <label>Book Description</label>
                                    <asp:TextBox ID="txtBookDescription" class="form-control" runat="server" placeholder="Full Postal Address" ReadOnly="True"
                                        TextMode="MultiLine"></asp:TextBox>

                                </div>
                            </div>

                        </div>

                        <br />
                        <%--below is pill badge--%>
                        <div class="row">
                                <div class="col-4">
                                    <asp:Button CssClass="btn btn-success w-100" ID="btnAdd" runat="server" Text="Add" />
                                </div>
                                <div class="col-4">
                                    <asp:Button CssClass="btn btn-warning w-100" ID="btnUpdate" runat="server" Text="Update" />
                                </div>
                                <div class="col-4">
                                    <asp:Button CssClass="btn btn-danger w-100" ID="btnDelete" runat="server" Text="Delete" />
                                </div>
                            </div>

                        </div>

                 </div>

                <a href="HomePage.aspx"><< Back to Home</a>
                <br />
                <br />
            </div>

                
       

            <div class="col-md-8">
                <div class="card">

                    <div class="card-body">

                        <div class="row">

                            <div class="col">
                                <center>
                                    <h4>Book Inventory  List</h4>
                                </center>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <hr />
                                </div>
                            </div>

                            <div class="row">
                                <div class="col">
                                    <asp:GridView class="table table-striped table-bordered" ID="gridViewBookInventory" runat="server"></asp:GridView>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>

        </div>
   </div>
</asp:Content>
