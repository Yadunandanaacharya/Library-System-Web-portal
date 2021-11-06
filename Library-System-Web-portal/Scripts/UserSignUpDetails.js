//jQuery.UserSignUpDetails.ServicePath = "";

var singUp = document.getElementById("btnSignUp");

//insert user details 
function InsertUserSignUpDetails() {
    
    var name = jQuery("#txtFullName").val();
    var dob = jQuery("#txtDOB").val();
    var contactNo = jQuery("#txtContactNumber").val();
    var email = jQuery("#txtEmail").val();
    var ddlState = $("[ID*=dropDownListState]");
    var selectedState = ddlState.find("option:selected").text();
    //alert($('#<%=dropDownListState.ClientID %> option:selected').text());
    var city = jQuery("#txtBoxCity").val();
    var pinCode = jQuery("#txtBoxPinCode").val();
    var address = jQuery("#txtBoxFullAddress").val();
    var memberID = jQuery("#txtBoxMemberID").val();
    var passWord = jQuery("#txtBoxPassword").val();
    //alert(name);
    var signUp = {};
    signUp.FullName = name;
    signUp.DOB = dob;
    signUp.ContactNo = contactNo;
    signUp.EmailID = email;
    signUp.State = selectedState;
    signUp.City = city;
    signUp.Pincode = pinCode;
    signUp.FullAddress = address;
    signUp.MemberID = memberID;
    signUp.Password = passWord;

    jQuery.ajax({
        type: "POST",
        url:  "WebServices/LibraryWebService.asmx/InsertUpdateUserDetails",
        data: JSON.stringify({ signUp: signUp }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var returnBasicInfo = json;
                dataInsertSuccessModal();
            }
        }
    });
}

//popup modal on sucessful insertion
function dataInsertSuccessModal() {
    
    jQuery("#divDataInsertedModal").modal("show");
}





//for login page check user exists or not
function CheckUserExists() {
    var memberID = jQuery("#txtMemberID").val();
    var passWord = jQuery("#txtPassword").val();
    var signUp = {};
    signUp.MemberID = memberID;
    signUp.Password = passWord;

    jQuery.ajax({
        type: "POST",
        //url: "WebServices/LibraryWebService.asmx/InsertUpdateUserDetails",
        url: "WebServices/LibraryWebService.asmx/CheckUserExists",
        data: JSON.stringify({ signUp: signUp }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json != undefined && json.d != undefined && json != null) {
                var returnBasicInfo = json;
                dataInsertSuccessModalUserLogin();
            }
        }
    });
}

function dataInsertSuccessModalUserLogin() {

    jQuery("#divDataInsertedModalUserLogin").modal("show");
}

//#region for test
function test() {
    //var name = $('#name').val();
    var name = jQuery("#txtFullName").val();

    var signUp = {};
    signUp.FullName = name;
    $.ajax({
            //url: 'testajax.asmx/HelloWorld',
        //url: 'WebServices/LibraryWebServices.asmx/HelloWorld',

        type: "POST",
        url: 'WebServices/LibraryWebService.asmx/InsertUpdateUserDetails',
        //data: { signUp: signUp },

        data: JSON.stringify({ signUp: signUp }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        //data: { myUserName: nameIs },
        //method: 'POST',
            //dataType: 'xml',
            success: function (data) {
                var jdata = $(data);
                alert(nameIs);
            }
        })
    alert('Hi');
}

//function test() {
//    //var name = $('#name').val();
//    var name = jQuery("#txtFullName").val();

//    //var signUp = {};
//    //signUp.FullName = name;
//    $.ajax({
//            url: 'testajax.asmx/HelloWorld',
//        //url: 'WebServices/LibraryWebServices.asmx/HelloWorld',

//        type: "POST",
//        //url: 'WebServices/LibraryWebService.asmx/InsertUpdateUserDetails',
//        //data: { signUp: signUp },

//        //data: JSON.stringify({ signUp: signUp }),
//        //contentType: "application/json; charset=utf-8",
//        //dataType: "json",
//        data: { myUserName: name },
//        method: 'POST',
//            dataType: 'xml',
//            success: function (data) {
//                var jdata = $(data);
//                alert(name);
//            }
//        })
//    alert('Hi');
//}

//#endregion 