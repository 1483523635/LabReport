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

