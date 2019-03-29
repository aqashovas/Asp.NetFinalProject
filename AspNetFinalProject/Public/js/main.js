$(document).ready(function () {

    $(".servicesec").last().addClass("offset-md-3");
    $(".servicesec").last().addClass(" offset - lg - 0");

 if ($(".categories").data("selected-id") !== "") {
            url += "&categoryid=" + $(".categories").data("selected-id");
        }

});