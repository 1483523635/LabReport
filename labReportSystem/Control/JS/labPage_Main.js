//通过动态的绑定连接 注意另一个界面传过去之后要对url进行解析

/**
 * 初始化函数
 */
$(function () {
    ReadUserData();
    InitFastEntrance();
    AddSubjectNameToSession();
    TeaNameList();
    SetScheme();
});

/*
 * 获取科目名称（通过session获取）
 */
function GetSubjectName() {
    //这是原来的用的是URL传科目名称
    //return decodeURI(window.location.href.split('?')[1].split('=')[1]);
    //这是新的用的是session传递取值
    return sessionStorage.getItem("subjectName");
}
//var subjectName = decodeURI(window.location.href.split('?')[1].split('=')[1]);
/*
 * 通过科目名获取实验实验次数
 * 时间：2017-4-4
 * author ：曲
 * @param {科目名称} subjectName
 */
function GetLabCount(subjectName) {
    var subCount = 0;
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/GetLabCount",
        data: "{'subjectName':'" + subjectName + "'}",
        success: function (data) {
            subCount = data.d;
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });
    return subCount;
}
/*
 * 将科目名称添加到session中去
 */
function AddSubjectNameToSession() {
    sessionStorage.setItem("LabCount", GetLabCount(GetSubjectName()));
};

/*
 * 初始化快速入口
 */
function InitFastEntrance() {
    var count = GetLabCount(GetSubjectName());
    for (var i = 1; i <= count; i++) {
        $(".list-unstyled").append($("<li><pre><a href=" + "labPage_model.html?labCount=" + i + ">第" + i + "次实验</a></pre></li>"));
    }
    //设置下一页的跳转路径
    if (count > 0) {
        $('.next').attr("href", $('.list-unstyled li pre a:first').attr("href"));
    }

}

/**
 * 读取用户的信息
 */
function ReadUserData() {
    /**
     * 通过session获取的用户名
     */
    var username = sessionStorage.getItem("username");
    /**
     * 设置科目名称
     */
    $('.subjectName > u').text(GetSubjectName());
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/GetUserDate",
        data: "{'username':'" + username + "'}",
        success: function (data) {
            var jsondata = eval(data.d);
            $('.stu_dept').text("院系：" + jsondata[0].Stuinfo_dept);
            $('.stu_id').text("学号：" + jsondata[0].Stuinfo_num);
            $('.stu_class').text("班级：" + jsondata[0].Stuinfo_class);
            $('.stu_major').text("专业：" + jsondata[0].Stuinfo_major);
            $('.stu_name').text("姓名：" + jsondata[0].Stuinfo_name);
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });

};

/*
*用户点击下一步时进行数据的提交
*/
$('.next').click(function () {
    //这里要进行数据的提交 用ajax进行数据的提交   
    var teacher = $('.teacher select option:selected').val();
    var local = $('.local input').val();
    var year = $('.year input').val();
    var username = sessionStorage.getItem("username");
    alert(teacher + local + year + username);
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/CommitData",
        data: "{'teaName':'" + teacher + "','local':'" + local + "','year':'" + year + "'}",
        success: function (data) {
            window.location.href = "";
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });
});

/**
 * 获取教师名（通过科目名称）
 */
function TeaNameList() {
    var subjectName = GetSubjectName();
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/GetTeacherList",
        data: "{'subjectName':'" + subjectName + "'}",
        success: function (data) {
            var teaNameList = eval(data.d);
            $('.teacher >select').empty();
            $.each(teaNameList,
                function (i) {
                    $("<option> " + teaNameList[i] + "</option>").appendTo(".teacher >select");
                });
            //获取当前选中的值
            //alert($('.teacher >select option:selected').val());
        },
        error: function (jqXHR, textStatus, errorThrown) {
            alert(textStatus + " " + errorThrown);
        }
    });
}
/**
 * 绑定学年学期的值
 */
function SetScheme() {
    $.ajax({
        async: false,
        dataType: "JSON",
        contentType: "Application/json",
        type: "post",
        url: "../../Control/Webservice/LabPage_Main.asmx/GetAllScheme",
        success: function (data) {
            $(".year >select").empty();
            var schemes = eval(data.d);
          //  alert(schemes[0].Year);
            $.each(schemes, function (i) {
                if(schemes[i].Year!=null)
                $("<option> " + schemes[i].Year + "</option>").appendTo(".year >select"); 
            });
        }

    });
}




































///**
// * 当下拉框选中的数值发生变化时触发的事件
// */
//function SelectChanged()
//{
//    var teacherName = $('.teacher select option:selected').val();    
//};


