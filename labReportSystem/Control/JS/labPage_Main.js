//通过动态的绑定连接 注意另一个界面传过去之后要对url进行解析
/**
 * 这个count值需要动态绑定 也就是从数据库中获取所需要的数据
 */
var count = 8;
for (var i = 1; i <= count; i++) {
    $(".list-unstyled").append($("<li><pre><a href=" + "labPage_model.html?labCount=" + i + ">第" + i + "次实验</a></pre></li>"));
}
//设置下一页的跳转路径
if (count > 0) {
    $('.next').attr("href",$('.list-unstyled li pre a:first').attr("href"));
}
/**
 * 读取用户的信息
 */
$(function() {
    var username = sessionStorage.getItem("username");
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/GetUserDate",
        data: "{'username':'" + username + "'}",
        success: function (data) {
            var jsondata = eval(data.d); 
            $('.stu_dept').text("院系："+jsondata[0].Stuinfo_dept);
            $('.stu_id').text("学号："+jsondata[0].Stuinfo_num);
            $('.stu_class').text("班级：" + jsondata[0].Stuinfo_class);
            $('.stu_major').text("专业：" + jsondata[0].Stuinfo_major);
            $('.stu_name').text("姓名："+jsondata[0].Stuinfo_name);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });

});
/**
*用户点击下一步时进行数据的提交
*/
$('.next').click(function() {
    //这里要进行数据的提交 用ajax进行数据的提交
    var teacher = $('.teacher select option:selected').val();
    var local = $('.local input').val();
    var year = $('.year input').val();
    var username = sessionStorage.getItem("username");
    alert(teacher + local + year+username);
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../Webservice/LabPage_Main.asmx/CommitData",
        data: "{'teaName':'" + teacher + "','local':'" + local + "','year':'"+year+"'}",
        success: function (data) {
            window.location.href = "";
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });
});

