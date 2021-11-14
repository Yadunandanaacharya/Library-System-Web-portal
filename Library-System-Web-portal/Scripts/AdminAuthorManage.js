jQuery.AuthorManagement = jQuery.AuthorManagement || {};
jQuery.AuthorManagement.PagerData = jQuery.AuthorManagement.PagerData || {};

function InitialLoadMethod(pagerData) {
    jQuery.AuthorManagement.PagerData = pagerData;
    GetAuthorDetails();
}

function GetAuthorDetails() {

    $('#dataTable').dataTable({
        ajax: {
            type: "POST",
            contentType: "application/json; charset=utf-8",
            url: jQuery.AuthorManagement.PagerData.ServicePath + "/LibraryWebService.asmx/GetAuthorDetails",
            dataSrc: function (json) {
                if (json !== undefined &&  json !== null) {
                   var dataIs = (json.d);
                    for (var i = 0; i < dataIs.AuthorDetails.length; i++) {
                        $('#tBody').append("<tr><td>" + dataIs.AuthorDetails[i].AuthorID + "</td><td>" + dataIs.AuthorDetails[i].AuthorName + "</td></tr></table>");
                    }
                }
            }
        },

        //below is required to remove loading message from first row of the table
            language: {
                emptyTable: "Loading",
                loadingRecords: "" //if you don't keep this empty then loading message will appear at first row
            },
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
                    alert("Author Updated Successfully")
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
                    alert("Author Deleted Successfully")
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