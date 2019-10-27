// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function () {
    $(".date-pick").datepicker(
        {
            dateFormat: 'dd.mm.yy',
            onSelect: function (date,inst) {
                $(this)[0].dispatchEvent(new Event('input', { 'bubbles': true }))
            }
        });

    $("#file").click(function () {
        let fname = "img";
        let url = "https://localhost:44373/images/ui-icons_cc0000_256x240.png";
        var link = document.createElement('a');
        link.href = url;
        link.download = fname;
        link.click();
        /*$.ajax({
            cache: false,
            url: "/Calc/GetFile",
            data: { imageUrl: "https://localhost:44373/images/ui-icons_cc0000_256x240.png", fileName: fname },
            success: function (data) {
                // download image to client browser
                var link = document.createElement('a');
                link.href = window.URL.createObjectURL(data);
                link.download = fname;
                link.click();
            },
            error: function (err) {
                alert(err);
            }
        });*/
    });

});

function tree_toggle(event) {
    event = event || window.event
    var clickedElem = event.target || event.srcElement

    if (!hasClass(clickedElem, 'Expand')) {
        return // клик не там
    }

    // Node, на который кликнули
    var node = clickedElem.parentNode
    if (hasClass(node, 'ExpandLeaf')) {
        return // клик на листе
    }

    // определить новый класс для узла
    var newClass = hasClass(node, 'ExpandOpen') ? 'ExpandClosed' : 'ExpandOpen'
    // заменить текущий класс на newClass
    // регексп находит отдельно стоящий open|close и меняет на newClass
    var re = /(^|\s)(ExpandOpen|ExpandClosed)(\s|$)/
    node.className = node.className.replace(re, '$1' + newClass + '$3')
}

function hasClass(elem, className) {
    return new RegExp("(^|\\s)" + className + "(\\s|$)").test(elem.className)
}