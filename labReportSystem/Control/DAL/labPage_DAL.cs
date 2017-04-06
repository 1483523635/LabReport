using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using labReportSystem.Model;

namespace labReportSystem.Control.DAL
{
    public class labPage_DAL
    {

        /// <summary>
        /// 向LabReport表中的添加一条数据
        /// 时间：2017-3-17
        /// author： 曲
        /// </summary>
        /// <param name="model">实体类</param>
        /// <returns>是否成功</returns>
        public bool InsertData(LabReport model)
        {

            string sql = "insert into  LabReport values(" +
                         model.LabReport_userid + ",'" + model.LabReport_subname + "','" +
                         model.LabReport_teaname + "','" + model.LabReport_location +
                         "','" + model.LabReport_date + "','" + model.LabReport_fill + "')";
            bool result = new SqlDB().ExecSql(sql);
            return result;
        }
        /// <summary>
        /// 更新表LabReport数据
        /// 时间：2017-3-17
        /// author：曲
        /// </summary>
        /// <param name="model">该表对应的实体类</param>
        /// <returns>是否成功</returns>
        public bool UpdateData(LabReport model)
        {

            string sql = "update  LabReport set " + 
                "LabReport_userid=" + model.LabReport_userid +
                ",LabReport_subname='" + model.LabReport_subname +
                "',LabReport_teaname='" + model.LabReport_teaname +
                "',LabReport_location='" + model.LabReport_location +
                "',LabReport_date='" + model.LabReport_date +
                "',LabReport_fill='" + model.LabReport_fill +
                 "' where LabReport_id=" + model.LabReport_userid;
            bool result = new SqlDB().ExecSql(sql);
            return result;
        }

        /// <summary>
        /// 判断LabReport中是否存在这样的一条数据
        /// </summary>
        /// <param name="model">实体类</param>
        /// <returns>是否存在</returns>
        public bool IsExistData(LabReport model)
        {

            string sql2 = "select * from LabReport where " +
                               "LabReport_userid = '" + model.LabReport_userid +
                          "'and LabReport_subname='" + model.LabReport_subname +
                          "'and LabReport_teaname='" + model.LabReport_teaname +
                          "'and LabReport_location='" + model.LabReport_location +
                          "'and LabReport_date='" + model.LabReport_date + "'";
            DataTable dt = new SqlDB().FillDt(sql2);
            if (dt.Rows.Count == 0)
                return true;
            return false;

        }

        /// <summary>
        /// /删除表中除了主键以外都相同的数据项
        /// </summary>
        /// <returns></returns>
        public bool DelateRepeat()
        {
            string sql1 = "delete LabReport where " +
                         "LabReport_id not  in  (select MIN(LabReport_id) from labReport " +
                         "group by LabReport_userid,LabReport_subname," +
                         "LabReport_teaname,LabReport_location," +
                         "LabReport_date,LabReport_fill)";
            return new SqlDB().ExecSql(sql1);
        }
    }
}