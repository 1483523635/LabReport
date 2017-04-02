$('<div/>').load('../footer.html').insertAfter($('.content'));
$(function () {
    //这里使用了session将用户名添加进去
    $("#user_name").text(sessionStorage.getItem("username"));
});