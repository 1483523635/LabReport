using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace labReportSystem.Control.DAL
{
    /// <summary>
    /// 实验详细类
    /// </summary>
    public class LabDetail_DAL
    {
        protected SqlDB SqlDb = null;

        public  LabDetail_DAL()
        {
            SqlDb=new SqlDB();
        }
        /// <summary>
        /// 通过科目名获取实验次数
        /// 时间：2017-4-4
        /// Author：曲
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <returns>实验次数</returns>
        public int GetLabConut(string subjectName)
        {
            string sql = "select count(Labcount) from labDetail where Ldtl_Subject='"+subjectName+"'";
            var dt= SqlDb.FillDt(sql);
            return (int)dt.Rows[0][0];
        }
    }
}