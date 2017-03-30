$('<div/>').load('../footer.html').insertAfter($('.content'));
$(function () {
    //这是通过URl传递过来的用户名进行解析的
    //var url = window.location.href;
    //var username = url.split('?')[1].split("#")[0].split("=")[1];
    //这里直接使用了session 
    $("#user_name").text(sessionStorage.getItem("username"));
});