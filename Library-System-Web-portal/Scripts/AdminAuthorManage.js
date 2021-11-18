jQuery.AuthorManagement = jQuery.AuthorManagement || {};
jQuery.AuthorManagement.PagerData = jQuery.AuthorManagement.PagerData || {};

var AuthorInfos = {};

function InitialLoadMethod(pagerData) {
    jQuery.AuthorManagement.PagerData = pagerData;
    var basicFilter = {};
    basicFilter.AuthorID = "";
    GetAuthorDetails(basicFilter);
}

function SearchAuthor() {
    var authorID = jQuery("#txtSearch").val();
    var basicFilter = {};
    basicFilter.AuthorID = authorID;
    GetAuthorDetails(basicFilter);
}

function ShowAllData() {
    jQuery("#txtSearch").val('');
    var authorID = "";
    var basicFilter = {};
    basicFilter.AuthorID = authorID;
    GetAuthorDetails(basicFilter);
}

function GetAuthorDetails(basicFilter) {
    var basicFilter = {};
   
    basicFilter.AuthorID = jQuery("#txtSearch").val();

    jQuery.ajax({
        type: "POST",
        url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/GetAuthorDetails",
        data: JSON.stringify({
            basicFilter: basicFilter
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function(json) {
            if (json !== undefined && json !== null) {
                var dataIs = (json.d);
                for (var i = 0; i < dataIs.AuthorDetails.length; i++) {
                    $('#tBody').append("<tr><td>" + dataIs.AuthorDetails[i].AuthorID + "</td><td>" + dataIs.AuthorDetails[i].AuthorName + "</td></tr></table>");
                }
            }
        },
        beforeSend: function () {
            jQuery("#tBody").empty();
        }
    });
}

function InsertAuthorDetails() {
    var authorID = jQuery("#txtAuthorID").val();
    var authorName = jQuery("#txtAuthorName").val();
    var authorDetails = {}
    authorDetails.AuthorID = authorID;
    authorDetails.AuthorName = authorName;

    jQuery.ajax({
        type: "POST",
        url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/InsertAuthor",
        data: JSON.stringify({
            authorDetails: authorDetails
        }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Inserted Successfully")
                    GetAuthorDetails();
                }
                else if (data == false) {
                    alert("Author already there")
                }
                
            }
            //GetAuthorDetails();
        }
    });
}

function UpdateAuthor() {
    var authorID = jQuery("#txtAuthorID").val();
    var authorName = jQuery("#txtAuthorName").val();
    var authorDetails = {}
    authorDetails.AuthorID = authorID;
    authorDetails.AuthorName = authorName;

    jQuery.ajax({
        type: "POST",
        url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/UpdateAuthor",
        data: JSON.stringify({ authorDetails: authorDetails }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Updated Successfully");
                    GetAuthorDetails();
                }
                else if (data == false) {
                    alert("New Author Inserted")
                }
            }
            //GetAuthorDetails();
        }
    });
}

function DeleteAuthor() {
    var authorID = jQuery("#txtAuthorID").val();

    jQuery.ajax({
        type: "POST",
        url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/DeleteAuthor",
        data: JSON.stringify({ authorID: authorID }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data == true) {
                    alert("Author Deleted Successfully");
                    GetAuthorDetails();
                }
                else if (data == false) {
                    alert("AuthorID doesn't exist")
                }
            }
            //GetAuthorDetails();
        }
    });
}

function CheckAuthor() {
    var authorID = jQuery("#txtAuthorID").val();

    jQuery.ajax({
        type: "POST",
        url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/CheckAuthor",
        data: JSON.stringify({ authorID: authorID }),
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (json) {
            if (json !== undefined && json !== undefined && json !== null) {
                var data = json.d;
                if (data.TotalRecord > 0) {
                    var authorDetails = data.AuthorDetails;
                    LoadAuthorName(authorDetails);
                }
            }
        }
    });
}

function LoadAuthorName(authorDetails) {
    if (authorDetails.length > 0) {
        var authorName = authorDetails[0].AuthorName;
        jQuery("#txtAuthorName").val(authorName);
    }
}