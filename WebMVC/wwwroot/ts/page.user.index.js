/// <reference path="jquery.d.ts" />
/// <reference path="jqueryui.d.ts" />
var isUpdateList = false;
function updateTable(usersCount, userFilter) {
    isUpdateList = true;
    $.post("GetUsers", {
        fromIndex: usersCount,
        filter: userFilter
    }).fail(function (error) {
        alert("Error load!");
    }).done(function (data) {
        if (usersCount == 1)
            $("#user-list").html(data);
        else
            $("#user-list").append(data);
        isUpdateList = false;
    });
}
$(document).ready(function () {
    var buttons = $(".user-fire-action");
    $(buttons).datepicker();
    $("#user-filter").keyup(function () {
        var usersCount = 1;
        var userFilter = $("#user-filter").val();
        updateTable(usersCount, userFilter);
    });
    $(window).scroll(function () {
        if ($(window).scrollTop() + $(window).height() >= $(document).height() - 200 && !isUpdateList) {
            var usersCount = $(".user").length + 1;
            var userFilter = $("#user-filter").val();
            updateTable(usersCount, userFilter);
        }
    });
});
//# sourceMappingURL=page.user.index.js.map