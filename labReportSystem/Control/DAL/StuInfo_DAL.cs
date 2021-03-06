﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using labReportSystem.Model;

namespace labReportSystem.Control.DAL
{
    public class StuInfo_DAL
    {
        private SqlDB sqlDb;

        public StuInfo_DAL()
        {
            sqlDb=new SqlDB();
        }
        /// <summary>
        /// 向stuinfo表中插入一条数据
        /// </summary>
        /// <param name="stuinfo">stuinfo实体类</param>
        /// <returns>bool</returns>
        public bool insertData(string user_Name, string stu_id, string stu_name, string stu_class, string stu_major, string stu_dept)
        {
            return new SqlDB().ExecSql("insert into Stuinfo values("+"dbo.getUserID('"+user_Name+"'),'"+stu_id+"','"+stu_name+"','"+stu_class+"','"+stu_major+"','"+stu_dept+"'");
        }

        /// <summary>
        /// 通过用户ID查找用户信息
        /// </summary>
        /// <param name="userid">用户的ID号</param>
        /// <returns>DT</returns>
        public DataTable GetUserInfo(string userid)
        {
            int userID = int.Parse(userid);
            string sql = "select Stuinfo_num  ,Stuinfo_name ,Stuinfo_class ,Stuinfo_major,Stuinfo_dept from stuinfo where stuinfo_userid=" + userID;
            return sqlDb.FillDt(sql);
        }
    }
}