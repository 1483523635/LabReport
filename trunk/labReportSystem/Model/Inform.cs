using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
    /// <summary>
    /// 实体类
    /// </summary>
    public class Inform
    {
        #region 成员
        /// <summary>
        /// ID 
        /// </summary>
        public String Inform_ID { get; set; }
        /// <summary>
        /// 发送方
        /// </summary>
        public String Inform_sender { get; set; }
        /// <summary>
        /// 接收者
        /// </summary>
        public String Inform_rec { get; set; }
        /// <summary>
        /// 通知内容
        /// </summary>
        public String Inform_content { get; set; }
        /// <summary>
        /// 时间
        /// </summary>
        public String Inform_time { get; set; }
        /// <summary>
        /// 状态 已读/未读
        /// </summary>
        public String Inform_state { get; set; }


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
            return "Inform";
        }
        /// <summary>
        ///返回主键字段名
        /// </summary>
        /// <returns></returns>
        public static string GetPkFieldName()
        {
            return "Inform_ID";
        }
        /// <summary>
        ///返回全路径类名
        /// </summary>
        /// <returns></returns>
        public static string GetFullClassName()
        {
            return " labReportSystem.Model.Inform";
        }
        /// <summary>
        ///返回属性列表
        /// </summary>
        /// <returns></returns>
        public static string[] GetAttrNames()
        {
            return new string[]
            {
               "Inform_ID"  ,
               "Inform_sender"  ,
               "Inform_rec"  ,
               "Inform_content"  ,
               "Inform_time"  ,
               "Inform_state"
            };
        }

        #endregion
    }
}

