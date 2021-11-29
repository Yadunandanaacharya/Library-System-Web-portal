jQuery.PublishManagement = jQuery.PublishManagement || {};
jQuery.PublishManagement.PagerData = jQuery.PublishManagement.PagerData || {};
jQuery.PublishManagement.BasicParam = {};
jQuery.PublishManagement.TotalRecord = 0;
jQuery.PublishManagement.PageStart = 0;

function InitialLoadMethod(pagerData) {
    jQuery.PublishManagement.PagerData = pagerData;
    var basicFilter = {};
    basicFilter.PublisherID = "";
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    GetPublisherDetails(basicFilter);
}

function SearchPublisher() {
    var publisherID = jQuery("#txtSearch").val();
    var basicFilter = {};
    basicFilter.PublisherID = publisherID;
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
    GetPublisherDetails(basicFilter);
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

function GetPublisherDetails(basicFilter) {

    jQuery.ajax({
        type: "POST",
        url: jQuery.PublishManagement.PagerData.ServicePath + "/LibraryWebService.asmx/GetPublisherDetails",
        data: JSON.stringify({
            basicFilter: basicFilter
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== null) {
                var dataIs = (json.d);
                for (var i = 0; i < dataIs.PublisherManage.PublisherDetails.length; i++) {
                    $('#tBody').append("<tr><td>" + dataIs.PublisherManage.PublisherDetails[i].PublisherID + "</td><td>" + dataIs.PublisherManage.PublisherDetails[i].PublisherName + "</td></tr></table>");
                }
                jQuery.PublishManagement.TotalRecord = json.d.TotalRecord;
                jQuery.PublishManagement.PageStart = json.d.PageStart;
            }
        },
        beforeSend: function () {
            jQuery("#tBody").empty();
        }
        //error handling is very very important in that reponsetext you can easily get errormessage which helps lot


    });
}

function InsertPublisherDetails() {
    var publisherID = jQuery("#txtPublisherID").val();
    var publisherName = jQuery("#txtPublisherName").val();
    var publisherDetails = {}
    publisherDetails.PublisherID = publisherID;
    publisherDetails.PublisherName = publisherName;

    jQuery.ajax({
        type: "POST",
        url: jQuery.PublishManagement.PagerData.ServicePath + "/LibraryWebService.asmx/InsertPublisher",
        data: JSON.stringify({
            publisherDetail: publisherDetails
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Inserted Successfully")
                    GetPublisherDetails();
                }
                else if (data == false) {
                    alert("Author already there")
                }

            }
            //GetAuthorDetails();
        }
    });
}

function UpdatePublisher() {
    var publisherID = jQuery("#txtPublisherID").val();
    var publisherName = jQuery("#txtPublisherName").val();
    var publisherDetails = {}
    publisherDetails.PublisherID = publisherID;
    publisherDetails.PublisherName = publisherName;

    jQuery.ajax({
        type: "POST",
        url: jQuery.PublishManagement.PagerData.ServicePath + "/LibraryWebService.asmx/UpdatePublisher",
        data: JSON.stringify({ publisherDetail: publisherDetails }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Updated Successfully");
                    GetPublisherDetails();
                }
                else if (data == false) {
                    alert("New Author Inserted")
                }
            }
        }
    });
}

function DeletePublisher() {
    var publisherID = jQuery("#txtPublisherID").val();

    jQuery.ajax({
        type: "POST",
        url: jQuery.PublishManagement.PagerData.ServicePath + "/LibraryWebService.asmx/DeletePublisher",
        data: JSON.stringify({ publisherID: publisherID }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Deleted Successfully");
                    GetPublisherDetails();
                }
                else if (data == false) {
                    alert("AuthorID doesn't exist")
                }
            }
        }
    });
}

function CheckPublisher() {
    var publisherID = jQuery("#txtPublisherID").val();

    jQuery.ajax({
        type: "POST",
        url: jQuery.PublishManagement.PagerData.ServicePath + "/LibraryWebService.asmx/CheckPublisher",
        data: JSON.stringify({ publisherID: publisherID }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data.TotalRecord > 0) {
                    var publisherDetails = data.PublisherDetails;
                    LoadPublisherName(publisherDetails);
                }
            }
        }
    });
}

function LoadPublisherName(publisherDetails) {
    if (publisherDetails.length > 0) {
        var publisherName = publisherDetails[0].PublisherName;
        jQuery("#txtPublisherName").val(publisherName);
    }
}

function NextPageIs() {
    var basicParam = {};

    var totalRecords = jQuery.PublishManagement.TotalRecord;
    var pageStart = jQuery.PublishManagement.PageStart;
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
    GetPublisherDetails(basicParam);
}

function PrevPageIs() {
    var basicParam = {};

    //var totalRecords = jQuery.PublishManagement.TotalRecord;
    var pageStart = jQuery.PublishManagement.PageStart;
    var recordsPerPage = 4;
    if (pageStart > 0) {
        pageStart = pageStart - recordsPerPage;
    }

    basicParam.PageStart = pageStart;
    basicParam.RecordsPerPage = 4;
    GetPublisherDetails(basicParam);
}

//#endregion
