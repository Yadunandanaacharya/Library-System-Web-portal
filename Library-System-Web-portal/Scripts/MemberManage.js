jQuery.MemberManagement =  {};
jQuery.MemberManagement.PagerData =  {};
jQuery.MemberManagement.BasicParam = {};
jQuery.MemberManagement.TotalRecord = 0;
jQuery.MemberManagement.PageStart = 0;

//below method loads when page loads and gets pagerdata variable from code behind of aspx.cs
//since in pagerdata we save web service path, I'm keeping all example adminmembermanage.aspx file inside
//another folder so this time if you use web service path with hardcoding your asmx file doesn't get brekpoint
//so to avoid that error we take web service path globally
function InitialLoadMethod(pagerData) {
    jQuery.MemberManagement.PagerData = pagerData;
    var basicFilter = {};
    basicFilter.MemberID = "";
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    GetMemberDetails(basicFilter);
}

//with respect to member id entered in textbox that we will pass to asmx method that will go to service side
//method this is how 3tier architecture works
function SearchPublisher() {
    var memberID = jQuery("#txtSearch").val();
    var basicFilter = {};
    basicFilter.memberID = memberID;
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    GetMemberDetails(basicFilter);
}

function ShowAllData() {
    jQuery("#txtSearch").val('');
    var authorID = "";
    var basicFilter = {};
    basicFilter.PublisherID = authorID;
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    GetPublisherDetails(basicFilter);
}

//once I get all data from service side I'm redering it to textboxes you can also use data-bind with less code.
function GetMemberDetails(basicFilter) {
    jQuery.ajax({
        type: "POST",
        url: jQuery.MemberManagement.PagerData.ServicePath + "/LibraryWebService.asmx/LoadMemberDetails",
        data: JSON.stringify({
            basicFilter: basicFilter
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== null) {
                var dataIs = (json.d);
                for (var i = 0; i < dataIs.MemberDetails.length; i++) {
                    $('#tBody').append("<tr><td>" + dataIs.MemberDetails[i].MemberID + "</td>" +
                        "<td>" + dataIs.MemberDetails[i].FullName + "</td>"  + 
                        "<td>" + dataIs.MemberDetails[i].AccountStatus + "</td>" + 
                        "<td>" + dataIs.MemberDetails[i].ContactNo + "</td>" + 
                        "<td>" + dataIs.MemberDetails[i].EmailID + "</td>" + 
                        "<td>" + dataIs.MemberDetails[i].State + "</td>" + 
                        "<td>" + dataIs.MemberDetails[i].City + "</td></tr></table>");
                }
                jQuery.MemberManagement.TotalRecord = json.d.TotalRecord;
                jQuery.MemberManagement.PageStart = json.d.PageStart;
            }
        },
        beforeSend: function () {
            jQuery("#tBody").empty();
        },
        error: function (request, error) {
            ShowWait('hide');
            if (request.responseText != "") {
                var errorMessage = jQuery.parseJSON(request.responseText);
                if (errorMessage != undefined && errorMessage != null && errorMessage.Message != undefined && errorMessage.Message != null) {
                    alert(errorMessage);
                }
                else {
                    alert(errorMessage);
                }
            }
            else {
                alert(errorMessage);
            }
        }
        //error handling is very very important in that reponsetext you can easily get errormessage which helps lot
    });
}

function CheckMember() {
    var publisherID = jQuery("#txtMemberID").val();
    var basicFilter = {};
    basicFilter.MemberID = publisherID;
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;

    jQuery.ajax({
        type: "POST",
        url: jQuery.MemberManagement.PagerData.ServicePath + "/LibraryWebService.asmx/LoadMemberDetails",
        data: JSON.stringify({ basicFilter: basicFilter }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data.TotalRecord > 0) {
                    
                    var memberDetails = data.MemberDetails;
                    jQuery("#txtFullName").val(memberDetails[0].FullName);
                    jQuery("#txtAccountStatus").val(memberDetails[0].AccountStatus);
                    jQuery("#txtDOB").val(memberDetails[0].DOB);
                    jQuery("#txtContactNO").val(memberDetails[0].ContactNo);
                    jQuery("#txtEmailID").val(memberDetails[0].EmailID);
                    jQuery("#txtState").val(memberDetails[0].State);
                    jQuery("#txtCity").val(memberDetails[0].City);
                    jQuery("#txtPinCode").val(memberDetails[0].Pincode);
                    jQuery("#txtFullPostalAddress").val(memberDetails[0].FullAddress);
                    var basicFilter = {};
                    basicFilter.MemberID = "";
                    basicFilter.PageStart = 0;
                    basicFilter.RecordsPerPage = 4;
                    GetMemberDetails(basicFilter);
                    
                }
            }
        },
        beforeSend: function () {
            jQuery("#tBody").empty();
        },
        error: function (request, error) {
            ShowWait('hide');
            if (request.responseText != "") {
                var errorMessage = jQuery.parseJSON(request.responseText);
                if (errorMessage != undefined && errorMessage != null && errorMessage.Message != undefined && errorMessage.Message != null) {
                    alert(errorMessage);
                }
                else {
                    alert(errorMessage);
                }
            }
            else {
                alert(errorMessage);
            }
        }
    });
}

//#region activate, deactivate, delete user permanently
//below code works but when you click on other button also it gets that click and page refreshes.
//$(function () {
//    $("button").click(function () {
//        var clickedButtonValue = $(this).val();
//        alert(clickedButtonValue);
//        MemberStatusUpdateOrDelete(clickedButtonValue)
//    });
//});

function ActivateMember() {
    var btnValue = 'A';
    MemberStatusUpdateOrDelete(btnValue);
}

function DeActivateMember() {
    var btnValue = 'I';
    MemberStatusUpdateOrDelete(btnValue);
}

function DeleteMember() {
    var publisherID = jQuery("#txtMemberID").val();
    if (publisherID != "") {
        var btnValue = 'D';
        MemberStatusUpdateOrDelete(btnValue);
    }
}

function MemberStatusUpdateOrDelete(memberStatusValue) {
    var publisherID = jQuery("#txtMemberID").val();
    var basicFilter = {};
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    basicFilter.MemberID = publisherID;
    basicFilter.AccountStatus = memberStatusValue;

    jQuery.ajax({
        type: "POST",
        url: jQuery.MemberManagement.PagerData.ServicePath + "/LibraryWebService.asmx/UpdateAccountStatus",
        data: JSON.stringify({ basicFilter: basicFilter }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json.d == true) {

                alert('Status Updated');
                var basicFilter = {};
                //basicFilter.PublisherID = authorID;
                basicFilter.PageStart = 0;
                basicFilter.RecordsPerPage = 4;
                GetMemberDetails(basicFilter);
                location.reload();
                //jQuery("#txtFullName").val(memberDetails[0].FullName);
                //jQuery("#txtAccountStatus").val(memberDetails[0].AccountStatus);

                //LoadPublisherName(publisherDetails);
            }
        }
    });
}

//#endregion

function NextPageIs() {
    var basicParam = {};

    var totalRecords = jQuery.MemberManagement.TotalRecord;
    var pageStart = jQuery.MemberManagement.PageStart;
    var recordsPerPage = 4;
    if (pageStart < totalRecords) {
        pageStart = pageStart + recordsPerPage;
    }
    if (pageStart >= totalRecords) {
        return  //since we don't have any loop like for, while, swith we can't use break here returns error stackoverflow.
        //use return here
    }
    basicParam.PageStart = pageStart;
    basicParam.RecordsPerPage = 4;
    GetMemberDetails(basicParam)
}

function PrevPageIs() {
    var basicParam = {};

    //var totalRecords = jQuery.PublishManagement.TotalRecord;
    var pageStart = jQuery.MemberManagement.PageStart;
    var recordsPerPage = 4;
    if (pageStart > 0) {
        pageStart = pageStart - recordsPerPage;
    }

    basicParam.PageStart = pageStart;
    basicParam.RecordsPerPage = 4;
    GetMemberDetails(basicParam)
}
