using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
    /// <summary>
    /// 实验内容实体类
    /// </summary>
    public class LabContent
    {
        #region 成员
        /// <summary>
        /// ID
        /// </summary>
        public String LabContent_id { get; set; }
        /// <summary>
        ///实验次数
        /// </summary>
        public String LabContent_count { get; set; }
        /// <summary>
        /// 实验报告册的主键
        /// </summary>
        public String LabContent_lrtid { get; set; }
        /// <summary>
        /// 实验项目
        /// </summary>
        public String LabContent_program { get; set; }
        /// <summary>
        /// 实验日期
        /// </summary>
        public String LabContent_date { get; set; }
        /// <summary>
        /// 实验成绩
        /// </summary>
        public String LabContent_score { get; set; }
        /// <summary>
        /// 内容1
        /// </summary>
        public String LabContent_content1 { get; set; }
        /// <summary>
        /// 内容2
        /// </summary>
        public String LabContent_content2 { get; set; }
        /// <summary>
        /// 内容三
        /// </summary>
        public String LabContent_content3 { get; set; }
        /// <summary>
        /// 内容四
        /// </summary>
        public String LabContent_content4 { get; set; }
        /// <summary>
        /// 内容五
        /// </summary>
        public String LabContent_content5 { get; set; }
        /// <summary>
        /// 内容六
        /// </summary>
        public String LabContent_content6 { get; set; }
        /// <summary>
        /// 内容七
        /// </summary>
        public String LabContent_content7 { get; set; }
        /// <summary>
        /// 内容八
        /// </summary>
        public String LabContent_content8 { get; set; }


        #endregion

        #region 属性


        #endregion

        #region 方法

        /// <summary>
        ///返回表名
        /// </summary>
        /// <returns></returns>
        public static string GetTableName()
        {
            return "LabContent";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public static string GetPkFieldName()
        {
            return "LabContent_id";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public static string GetFullClassName()
        {
            return " labReportSystem.Model.LabContent";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetAttrNames()
        {
            return new string[]
            {
"LabContent_id",
"LabContent_count",
"LabContent_lrtid",
"LabContent_program",
"LabContent_date",
"LabContent_score",
"LabContent_content1",
"LabContent_content2",
"LabContent_content3",
"LabContent_content4",
"LabContent_content5",
"LabContent_content6",
"LabContent_content7",
"LabContent_content8",
            };
        }

        #endregion
    }
}

