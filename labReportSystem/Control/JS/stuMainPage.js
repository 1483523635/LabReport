$('<div/>').load('../footer.html').insertAfter($('.content'));
$(function() {
    var url = window.location.href;
    var username = url.split('?')[1].split("#")[0].split("=")[1];
    $("#user_name").text(username);
});