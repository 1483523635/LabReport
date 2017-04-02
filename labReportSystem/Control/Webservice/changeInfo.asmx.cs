using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using labReportSystem.Control.DAL;
using labReportSystem.Model;

namespace labReportSystem.Control.Webservice
{
    /// <summary>
    /// changeInfo 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允许使用 ASP.NET AJAX 从脚本中调用此 Web 服务，请取消注释以下行。 
    [System.Web.Script.Services.ScriptService]
    public class changeInfo : System.Web.Services.WebService
    { 
       /// <summary>
       /// 向学生信息表中添加一条数据
       /// </summary>
       /// <param name="user_Name">Users的主键</param>
       /// <param name="stu_id">学号</param>
       /// <param name="stu_name">姓名</param>
       /// <param name="stu_class">班级</param>
       /// <param name="stu_major">专业</param>
       /// <param name="stu_dept">系别</param>
       /// <returns>是否成功</returns>
        [WebMethod]
        public bool Insertdata(string user_Name, string stu_id, string stu_name, string stu_class, string stu_major, string stu_dept)
       {
           return new StuInfo_DAL().insertData(user_Name, stu_id, stu_name, stu_class, stu_major, stu_dept);
       }
    
    }
}
