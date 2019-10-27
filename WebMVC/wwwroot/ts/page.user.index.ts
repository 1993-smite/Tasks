/// <reference path="jquery.d.ts" />
/// <reference path="jqueryui.d.ts" />

let isUpdateList: boolean = false;

function updateTable(usersCount: number, userFilter: string) {
    isUpdateList = true;
    $.post("GetUsers",
        {
            fromIndex: usersCount,
            filter: userFilter
        }
    ).fail(function (error: any) {
        alert("Error load!");
    }).done(function (data: any) {
        if (usersCount == 1)
            $("#user-list").html(data);
        else 
            $("#user-list").append(data);
        isUpdateList = false;
    });
}

$(document).ready(function () {
    let buttons: any = $(".user-fire-action");
    $(buttons).datepicker();

    $("#user-filter").keyup(function () {
        let usersCount: number = 1;
        let userFilter: string = $("#user-filter").val();
        updateTable(usersCount, userFilter);
    });

    $(window).scroll(function () {
        if ($(window).scrollTop() + $(window).height() >= $(document).height() - 200 && !isUpdateList) {
            let usersCount: number = $(".user").length + 1;
            let userFilter: string = $("#user-filter").val();
            updateTable(usersCount, userFilter);
        }
    });
});