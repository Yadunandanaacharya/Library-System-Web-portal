<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="knockoutExample.aspx.cs" Inherits="Library_System_Web_portal.knockoutExample" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://ajax.aspnetcdn.com/ajax/knockout/knockout-3.1.0.js"
        type="text/javascript"></script>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>


</head>
<body>  
        <form id="form1" runat="server">  
            <div>  
                <label>Choose Your Car</label>  
                <select data-bind="options: availableCars, optionsText: 'carName', value: selectedCar, optionsCaption: 'Choose...'"></select>  
                <br />  
                <br />  
                <div data-bind="visible: selectedCar">  
                    Choosed Car is of Rs  
                    <span data-bind="text: selectedCar() ? selectedCar().price : 'unknown'"></span>.  
                </div>  
            </div>  
            <script type="text/javascript">  
            function Car(name, price) {  
                this.carName = name;  
                this.price = price;  
            };  
  
            function x() {  
                availableCars = ko.observableArray([  
                    new Car("i10", 450000),  
                    new Car("120", 700000),  
                    new Car("Verna", 1200000)  
                ]);  
                selectedCar = ko.observable();  
            };  
            ko.applyBindings(new x());  
            </script>  
        </form>  
    </body>  
</html>
