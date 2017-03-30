using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using labReportSystem.Model;

namespace labReportSystem.Control.DAL
{
    public class ChangeStuInfo_DAL
    {
        /// <summary>
        /// 向stuinfo表中插入一条数据
        /// </summary>
        /// <param name="stuinfo">stuinfo实体类</param>
        /// <returns>bool</returns>
        public bool insertData(string user_Name, string stu_id, string stu_name, string stu_class, string stu_major, string stu_dept)
        {
            return new SqlDB().ExecSql("insert into Stuinfo values("+"dbo.getUserID('"+user_Name+"'),'"+stu_id+"','"+stu_name+"','"+stu_class+"','"+stu_major+"','"+stu_dept+"'");
        }
    }
}