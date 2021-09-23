<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Library_System_Web_portal.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <section>
        <img src="Images/Home.bg.png"    style="width:1600px;object-fit:cover;height:100px"   />
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
            </div>


        </div>
    </section>

</asp:Content>
