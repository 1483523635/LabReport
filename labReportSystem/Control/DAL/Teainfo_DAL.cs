using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    /// <summary>
    /// 教师信息表类
    /// </summary>
    public class Teainfo_DAL
    {
        private SqlDB sqlDb;
        public Teainfo_DAL()
        {
            sqlDb = new SqlDB();
        }

        /// <summary>
        /// 获取教师表中所有的数据
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <param name="scheme">授课学期</param>
        /// <returns></returns>
        public DataTable GetTeaTableInfo(string subjectName,string scheme=null)
        {
            
           string  sql = "select * from Teainfo where ( Teainfo_sub1='" + subjectName +
                     "' or Teainfo_sub2='" + subjectName + "' or Teainfo_sub3='" + subjectName +
                     "' or Teainfo_sub4='" + subjectName + "' or Teainfo_sub5='" + subjectName + "')";
            if (scheme != null)
            {
                sql += " and Teainfo_scheme='" + scheme + "'";
            }          
            return sqlDb.FillDt(sql);
        }
    }
}