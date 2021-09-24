<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Library_System_Web_portal.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section>
        <img src="Images/Home.bg.png" class="img-fluid"   style="width:1600px;object-fit:cover;height:150px"   />
    </section>

    <section>

        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Features</h2>
                        <p><b>Our 3 Primary Features-</b></p>
                    </center>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4" >
                    <center>
                        <img  width="150px" src="Images/digitalBookInventory.jfif" />
                        <h4>Digital Book Inventory</h4>
                        <p style="width:18em;text-align:justify;">An inventory is the one method that libraries and archives 
                        use to determine whether some items in their collection are 
                        in need of preservation or conservation activities.</p>
                    </center>
                </div>
                 <div class="col-md-4" >
                    <center>
                        <img  width="150px" height="90px" src="Images/bookSearch.jfif" />
                        <h4>Book Search</h4>
                        <p style="width:18em;text-align:justify;">If you don't find the book or author you're looking for in the first 
                            page of results the chances are it's because it is not one that we have featured. </p>
                    </center>
                </div>
                 <div class="col-md-4" >
                    <center>
                        <img  width="150px" src="Images/defaulter.jfif" />
                        <h4>Defaulter List</h4>
                        <p style="width:18em;text-align:justify;">Other solutions- multiple notices and billings, cablegrams, staff
                            collectors- are dismissed as not cost-effective. </p>
                    </center>
                </div>


            </div>


        </div>
    </section>
    <br />
    <br />
    <section>

        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                        <h2>Our Process</h2>
                        <p><b>Our best 3 step process</b></p>
                    </center>
                </div>
            </div>

            <div class="row">
                <div class="col-md-4" >
                    <center>
                        <img  width="150px" src="Images/signUp.jfif" />
                        <h4>Sign Up</h4>
                        <p style="width:18em;text-align:justify;">A single username and password gets you into everything Google (Gmail, Chrome, YouTube, Google Maps). Set up your profile and preferences just the way you like. </p>
                    </center>
                </div>
                 <div class="col-md-4" >
                    <center>
                        <img  width="150px" height="90px" src="Images/bookSearch.jfif" />
                        <h4>Search Books</h4>
                        <p style="width:18em;text-align:justify;">If you don't find the book or author you're looking for in the first 
                            page of results the chances are it's because it is not one that we have featured. </p>
                    </center>
                </div>
                 <div class="col-md-4" >
                    <center>
                        <img  width="150px" src="Images/visitus.jfif" />
                        <h4>Visit Us</h4>
                        <p style="width:18em;text-align:justify;">Use the largest library in the world online or in person! More about the Library. Plan Your Visit · </p>
                    </center>
                </div>


            </div>


        </div>
    </section>

</asp:Content>
