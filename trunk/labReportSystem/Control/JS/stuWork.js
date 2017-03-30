/**
 * 动态生成元素 
 * Author 曲
 *时间：2016-12-2
 */
$('.example').attr('data-text', 'C语言');
$('.example').append($("<div class='grid no-margin-top'>" +
    " <div class='row cells10'></div></div>"));
var $cell = $('.cells10');
for (var i = 1; i <= 8; i++) {
    $cell.append($("   <div class='cell'> " +
                          "<div class='image-container'>" +
                                 "<div class='img '>" +
                                    " <img src='../../Resouce/IMG/backgroundpic.jpg' />" +
                                 "</div>" +
                                     "<div class='image-overlay op-green'>" +
                                        "<h2 class='labconut'>"+i+"</h2>" +
                                      "</div>" +
                            "</div>" +
                       "</div>"
    ));
}
/**
 * 每个单元格被点击时处理的事件
 */
$('.cell').click(function () {
    //获取当前点击的元素的文本值
   // alert($(this).text());
    window.location.href = "../labReport/labPage_Main.html";
});