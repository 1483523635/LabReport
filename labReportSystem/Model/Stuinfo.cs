using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
    /// <summary>
    /// 实体类
    /// </summary>
    public class Stuinfo
    {
        #region 成员
        /// <summary>
        ///ID 
        /// </summary>
        public String Stuinfo_ID { get; set; }
        /// <summary>
        /// Users主键
        /// </summary>
        public String Stuinfo_userid { get; set; }
        /// <summary>
        /// 学号
        /// </summary>
        public String Stuinfo_num { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public String Stuinfo_name { get; set; }
        /// <summary>
        /// 班级
        /// </summary>
        public String Stuinfo_class { get; set; }
        /// <summary>
        /// 专业
        /// </summary>
        public String Stuinfo_major { get; set; }
        /// <summary>
        /// 系别
        /// </summary>
        public String Stuinfo_dept { get; set; }

        #endregion

        #region 方法

        /// <summary>
        ///返回表名
        /// </summary>
        /// <returns></returns>
        public static string GetTableName()
        {
            return "Stuinfo";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public static string GetPkFieldName()
        {
            return "Stuinfo_ID";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public static string GetFullClassName()
        {
            return " labReportSystem.Model.Stuinfo";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetAttrNames()
        {
            return new string[] { "Stuinfo_ID", "Stuinfo_userid", "Stuinfo_ID_num", "Stuinfo_name", "class", "Stuinfo_major", "Stuinfo_dept" };
        }

        #endregion
    }
}

