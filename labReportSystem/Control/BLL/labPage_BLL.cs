﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using labReportSystem.Common;
using labReportSystem.Control.DAL;
using labReportSystem.Model;

namespace labReportSystem.Control.BLL
{
    public class labPage_BLL
    {
        /// <summary>
        /// 提交数据到数据库中
        /// </summary>
        /// <param name="modelReport">实验报告册LabReport实体类</param>
        /// <returns></returns>
        public bool CommitData(LabReport modelReport)
        {
           labPage_DAL page=new labPage_DAL();
            //return page.IsExistData(modelReport);
            //不存在时返回true
            //删除重复元素
            page.DelateRepeat();
            if (page.IsExistData(modelReport))
            {
                return page.InsertData(modelReport);
            }
            return page.UpdateData(modelReport);
        }

        /// <summary>
        /// 获取用户信息通过json串进行返回
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public string GetUserDate(string username)
        {
            string userID = new Users_DAL().GetUserId(username);
            return new StuInfo_DAL().GetUserInfo(userID).ConvertToJson();
        }

        /// <summary>
        /// 通过科目名称获取实验次数
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <returns></returns>
        public int GetLabCount(string subjectName)
        {
            return new LabDetail_DAL().GetLabConut(subjectName);
        }

        /// <summary>
        ///获取教师姓名的list
        /// </summary>
        /// <param name="subjectName">科目名称</param>
        /// <param name="scheme">授课学期</param>
        /// <returns></returns>
        public string GetTeaNameList(string subjectName,string scheme=null)
        {
            DataTable sourceTable = new Teainfo_DAL().GetTeaTableInfo(subjectName, scheme);
            List<string> teaNameList=new List<string>();
            for (int i = 0; i < sourceTable.Rows.Count; i++)
            {
                teaNameList.Add(sourceTable.Rows[i]["Teainfo_name"].ToString());
            }
            return teaNameList.ConvertToJson();
        }

        /// <summary>
        /// 获取所有的学年学期
        /// </summary>
        /// <returns>JSON串</returns>
        public string GetAllScheme()
        {
           return new Other_DAL().GetSomeInfo("Year").ConvertToJson(); 
        }
    }
}