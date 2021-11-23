jQuery.AuthorManagement = jQuery.AuthorManagement || {};
jQuery.AuthorManagement.PagerData = jQuery.AuthorManagement.PagerData || {};
jQuery.AuthorManagement.BasicParam = {};
jQuery.AuthorManagement.TotalRecord = 0;
jQuery.AuthorManagement.PageStart = 0;


var AuthorInfos = {};

function InitialLoadMethod(pagerData) {
    jQuery.AuthorManagement.PagerData = pagerData;
    var basicFilter = {};
    basicFilter.AuthorID = "";
    basicFilter.PageStart = 0;
    basicFilter.RecordsPerPage = 4;
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
   
    //basicFilter.AuthorID = jQuery("#txtSearch").val();
    //basicFilter.PageStart = 0;
    //basicFilter.RecordsPerPage = 4;

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
                for (var i = 0; i < dataIs.AuthorManage.AuthorDetails.length; i++) {
                    $('#tBody').append("<tr><td>" + dataIs.AuthorManage.AuthorDetails[i].AuthorID + "</td><td>" + dataIs.AuthorManage.AuthorDetails[i].AuthorName + "</td></tr></table>");
                }
                jQuery.AuthorManagement.TotalRecord = json.d.TotalRecord;
                jQuery.AuthorManagement.PageStart = json.d.PageStart;
            }
        },
        beforeSend: function () {
            jQuery("#tBody").empty();
        }
        //error handling is very very important in that reponsetext you can easily get errormessage which helps lot


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

//#region pagination logics

//var current_page = 1;
//var records_per_page = 2;

//var objJson = [
//    { adName: "AdName 1" },
//    { adName: "AdName 2" },
//    { adName: "AdName 3" },
//    { adName: "AdName 4" },
//    { adName: "AdName 5" },
//    { adName: "AdName 6" },
//    { adName: "AdName 7" },
//    { adName: "AdName 8" },
//    { adName: "AdName 9" },
//    { adName: "AdName 10" }
//]; // Can be obtained from another source, such as your objJson variable

//function prevPage() {
//    if (current_page > 1) {
//        current_page--;
//        changePage(current_page);
//    }
//}

//function nextPage() {
//    if (current_page < numPages()) {
//        current_page++;
//        changePage(current_page);
//    }
//}

//function changePage(page) {
//    var btn_next = document.getElementById("btn_next");
//    var btn_prev = document.getElementById("btn_prev");
//    var listing_table = document.getElementById("listingTable");
//    var page_span = document.getElementById("page");

//    // Validate page
//    if (page < 1) page = 1;
//    if (page > numPages()) page = numPages();

//    listing_table.innerHTML = "";

//    for (var i = (page - 1) * records_per_page; i < (page * records_per_page); i++) {
//        listing_table.innerHTML += objJson[i].adName + "<br>";
//    }
//    page_span.innerHTML = page;

//    if (page == 1) {
//        btn_prev.style.visibility = "hidden";
//    } else {
//        btn_prev.style.visibility = "visible";
//    }

//    if (page == numPages()) {
//        btn_next.style.visibility = "hidden";
//    } else {
//        btn_next.style.visibility = "visible";
//    }
//}

//function numPages() {
//    return Math.ceil(objJson.length / records_per_page);
//}

//window.onload = function () {
//    changePage(1);
//};


//by me
function NextPageIs() {
    var basicParam = {};

    var totalRecords = jQuery.AuthorManagement.TotalRecord;
    var pageStart = jQuery.AuthorManagement.PageStart;
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
    GetAuthorDetails(basicParam);
   
}

function PrevPageIs() {
    var basicParam = {};

    //var totalRecords = jQuery.AuthorManagement.TotalRecord;
    var pageStart = jQuery.AuthorManagement.PageStart;
    var recordsPerPage = 4;
    if (pageStart > 0) {
        pageStart = pageStart - recordsPerPage;
    }
    
    basicParam.PageStart = pageStart;
    basicParam.RecordsPerPage = 4;
    GetAuthorDetails(basicParam);

}


//#endregion
