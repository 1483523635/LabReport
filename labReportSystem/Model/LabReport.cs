using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
    /// <summary>
    /// 实体类
    /// </summary>
    public class LabReport
    {
        #region 成员
        /// <summary>
        /// ID
        /// </summary>
        public String LabReport_id { get; set; }
        /// <summary>
        /// 用户ＩＤ
        /// </summary>
        public String LabReport_userid { get; set; }
        /// <summary>
        /// 科目名称
        /// </summary>
        public String LabReport_subname { get; set; }
        /// <summary>
        /// 教师名称
        /// </summary>
        public String LabReport_teaname { get; set; }
        /// <summary>
        /// 实验地点
        /// </summary>
        public String LabReport_location { get; set; }
        /// <summary>
        /// 学期学年
        /// </summary>
        public String LabReport_date { get; set; }
        /// <summary>
        /// 填写说明
        /// </summary>
        public String LabReport_fill { get; set; }


        #endregion

        #region 方法

        /// <summary>
        ///返回表名
        /// </summary>
        /// <returns></returns>
        public static string GetTableName()
        {
            return "LabReport";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public static string GetPkFieldName()
        {
            return "LabReport_id";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public static string GetFullClassName()
        {
            return " labReportSystem.Model.LabReport";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetAttrNames()
        {
            return new string[] {
"LabReport_id"   ,
"LabReport_userid"   ,
"LabReport_subname"   ,
"LabReport_teaname"   ,
"LabReport_location"   ,
"LabReport_date"   ,
"LabReport_fill"                   
 };
        }

        #endregion
    }
}

