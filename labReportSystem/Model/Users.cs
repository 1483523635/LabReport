using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LabReportSystem
{
    /// <summary>
    /// 用户表
    /// </summary>
    public class Users
    {
        #region 成员
        /// <summary>
        /// ID
        /// </summary>
        public  int Users_id{get;set;}
        /// <summary>
        /// 用户名
        /// </summary>
        public  string Users_name{get;set;}
        /// <summary>
        /// 密码
        /// </summary>
        public  string Users_pwd{get;set;}
        /// <summary>
        /// 用户权限 1，2，3 默认为1
        /// </summary>
        public  string Users_right { get; set; }
        /// <summary>
        /// 备用字段1
        /// </summary>
        public string Users_rreserve1 { get; set; }
        /// <summary>
        /// 备用字段2
        /// </summary>
        public string Users_rreserve2 { get; set; }
        #endregion

        #region 方法

        /// <summary>
        ///返回表名
        /// </summary>
        /// <returns></returns>
        public string GetTableName()
        {
            return "Users";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public string GetPkFieldName()
        {
            return "Users_id";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public string GetFullClassName()
        {
            return "LabReportSystem.Users";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public string[] GetAttrNames()
        {
            return new string[] { "Users_id","Users_name","Users_pwd","Users_right","Users_reserve1","Users_reserve2"};
        }

        #endregion
    }
}

