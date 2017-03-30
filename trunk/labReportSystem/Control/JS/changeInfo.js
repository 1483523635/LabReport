$(".success").click(function () {
    var stu_id = $(".stu_id");
    var stu_name = $(".stu_name");
    var stu_class = $(".stu_class");
    var stu_major = $(".stu_major");
    var stu_dept = $(".stu_dept");
    var user_name = getUseName();
    if (user_ID == undefined || user_ID.trim().length==0) {
        alert("非法操作！");
        window.location.href = "../Login.html";
        return;
    }
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/changeInfo.asmx/Insertdata",
        data: "{'user_Name':'"+user_name+"','stu_id':'" + stu_id.val() + "','stu_name':'" + stu_name.val() + "','stu_major':'" + stu_major.val()
            + "','stu_dept':'"+stu_dept.val()+"'}",
        suceess: function(data) {
            alert(data.d);
        },
        error: function() {
            alert("chucuole");
        }
    });
});

function getUseName() {
    var name;
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/UserLogin.asmx/GetUserName",
        success: function (data) {
            name=data.d;
        },
        error: function (jqXHR, textStatus, errorThrown) {
        alert("出错了"+textStatus + " " + errorThrown);
    }
    });
    return name;
};