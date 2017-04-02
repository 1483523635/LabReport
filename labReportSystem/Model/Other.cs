using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labReportSystem.Model
{
	/// <summary>
	/// 其他杂项类
	/// 主要用于维护一些数据
	/// </summary>
	public class Other
	{
		#region 成员

		private string year;
		private string subject;
		private string dept;
		private string reserve;

		#endregion

		#region 属性

		/// <summary>
		/// 学年学期
		/// </summary>
		public string Year
		{
			get { return year; }
			set { year = value; }
		}
		/// <summary>
		/// 科目名称
		/// </summary>
		public string Subject
		{
			get { return subject; }
			set { subject = value; }
		}
		/// <summary>
		/// 院系名称
		/// </summary>
		public string Dept
		{
			get { return dept; }
			set { dept = value; }
		}
		/// <summary>
		/// 预留字段
		/// </summary>
		public string Reserve
		{
			get { return reserve; }
			set { reserve = value; }
		}

		#endregion

		#region 方法

		/// <summary>
		///返回表名
		/// </summary>
		/// <returns></returns>
		public string GetTableName()
		{
			return "Other";
		}
		/// <summary>
		///返回全路径类名
		/// </summary>
		/// <returns></returns>
		public string GetFullClassName()
		{
			return "labReportSystem.Model.Other";
		}
		/// <summary>
		///返回属性列表
		/// </summary>
		/// <returns></returns>
		public string[] GetAttrNames()
		{
			return new string[]{ "Year", "Subject", "Dept", "Reserve" };
		}

		#endregion
	}
}

