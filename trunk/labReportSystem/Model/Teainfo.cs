using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
    /// <summary>
    /// 教师信息实体类
    /// </summary>
    public class Teainfo
    {
        #region 成员
        /// <summary>
        /// ID
        /// </summary>
        public String Teainfo_ID { get; set; }
        /// <summary>
        /// users表主键
        /// </summary>
        public String Teainfo_userid { get; set; }
        /// <summary>
        /// 教师姓名
        /// </summary>
        public String Teainfo_name { get; set; }
        /// <summary>
        /// 所教科目1
        /// </summary>
        public String Teainfo_sub1 { get; set; }
        /// <summary>
        /// 所教科目2
        /// </summary>
        public String Teainfo_sub2 { get; set; }
        /// <summary>
        /// 所教科目3
        /// </summary>
        public String Teainfo_sub3 { get; set; }
        /// <summary>
        /// 所教科目4
        /// </summary>
        public String Teainfo_sub4 { get; set; }
        /// <summary>
        /// 所教科目5
        /// </summary>
        public String Teainfo_sub5 { get; set; }


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
            return "Teainfo";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public static string GetPkFieldName()
        {
            return "Teainfo_ID";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public static string GetFullClassName()
        {
            return " labReportSystem.Model.Teainfo";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetAttrNames()
        {
            return new string[] { "Teainfo_ID", "Teainfo_userid", "Teainfo_name", "Teainfo_sub1", "Teainfo_sub2", "Teainfo_sub3", "Teainfo_sub4", "Teainfo_sub5" };

        }

        #endregion
    }
}

