
jQuery(function ($) {
    $.datepicker.regional['zh-CN'] = {
        closeText: '关闭',
        prevText: '<上月',
        nextText: '下月>',
        currentText: '今天',
        monthNames: ['一月', '二月', '三月', '四月', '五月', '六月',
        '七月', '八月', '九月', '十月', '十一月', '十二月'],
        monthNamesShort: ['一', '二', '三', '四', '五', '六',
        '七', '八', '九', '十', '十一', '十二'],
        dayNames: ['星期日', '星期一', '星期二', '星期三', '星期四', '星期五', '星期六'],
        dayNamesShort: ['周日', '周一', '周二', '周三', '周四', '周五', '周六'],
        dayNamesMin: ['日', '一', '二', '三', '四', '五', '六'],
        weekHeader: '周',
        dateFormat: 'yy-mm-dd',
        firstDay: 1,
        isRTL: false,
        showMonthAfterYear: true,
        yearSuffix: '年'
    };
    $.datepicker.setDefaults($.datepicker.regional['zh-CN']);
});
$(function () {
    //设置日历控件
    $("#datepicker").datepicker();
    $.datepicker.setDefaults($.datepicker.regional['zh-CN']);
    //设置标题控件
    $("#accordion").accordion();
  
     
});
//解析url  获传过来的数据（实验次数）
var $url = window.location.href;
var Labcount = $url.split("?")[1].split("=")[1];
var labTotalCount = 8;
for (var i = 1; i <=labTotalCount; i++) {
    if (i ==Labcount) {
        $(".list-unstyled").append($("<li><pre><a href=" + "#?labCount=" + i + ">第" + i + "次实验</a></pre></li>"));
        continue;
    }
    $(".list-unstyled").append($("<li><pre><a href=" + "labPage_model.html?labCount=" + i + ">第" + i + "次实验</a></pre></li>"));
}
