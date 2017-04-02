//加载tab键的tab内容 并绑定事件
$('#tabs-1').load('Temp_login.html', function (responseText, textStatus) {
  
    if (textStatus == "success") {
        $('#tabs-1 .form-actions .primary').attr("id", "stu_login");
        $("#stu_login").click(stu);
    }
});
$('#tabs-2').load('Temp_login.html', function (responseText, textStatus) {
    if (textStatus == "success") {
        $('#tabs-2 .form-actions .primary').attr("id", "tea_login");
        $("#tea_login").click(tea);
        
    }
});
$('#tabs-3').load('Temp_login.html', function (responseText, textStatus) {
    if (textStatus == "success") {
        $('#tabs-3 .form-actions .primary').attr("id", "admin_login");
        $("#admin_login").click(admin);
    }
});

//学生登陆时
function stu() {
    var $stuname = $("#tabs-1 .text input ");
    var $stuPwd = $("#tabs-1 .password input");
    if ($stuname == undefined || $stuname.val().trim().length == 0 || $stuPwd == undefined || $stuPwd.val().length == 0) {
        alert("请输入完整信息！");
        return;
    }
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType:"Application/json",
        type: "post",
        url: "../Control/Webservice/UserLogin.asmx/Login",
        data: "{'name':'"+$stuname.val()+"','pwd':'"+$stuPwd.val()+"'}",
        success: function (data) {
            if (data.d == false) {
                alert("账号和密码不匹配！");
                return;
            }
            sessionStorage.setItem("username", $stuname.val());
            //这是原来的
           // window.location.href = "stuView/stuMainPage.html?userID=" + $stuname.val();  
            //这是最新的
            window.location.href = "stuView/stuMainPage.html";
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });


    // window.location.href = "stuView/stuMainPage.html";
};
//教师登陆时
function tea() {
    window.location.href = "stuView/stuMainPage.html";
};



//admin 登陆时
function admin() {
   
};
/**
 * 判断账号和密码是否合法
 * @param {id} id
 * @param {pwd} pwd 
 * @returns {bool} 
 * 合法返回true
 * else return false 
 */
function illegal(id, pwd) {

    if (id == undefined || id.trim().length == 0 || pwd == undefined || pwd.trim().length == 0) {
        alert("请输入完整信息");
        return false;
    }
    return true;
}
