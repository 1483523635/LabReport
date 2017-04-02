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

		private int teainfo_userid;
		private string teainfo_name;
		private string teainfo_sub1;
		private string teainfo_sub2;
		private string teainfo_sub3;
		private string teainfo_sub4;
		private string teainfo_sub5;
		private string teainfo_scheme;

		#endregion

		#region 属性

		/// <summary>
		/// User主键
		/// </summary>
		public int Teainfo_userid
		{
			get { return teainfo_userid; }
			set { teainfo_userid = value; }
		}
		/// <summary>
		/// 教师姓名
		/// </summary>
		public string Teainfo_name
		{
			get { return teainfo_name; }
			set { teainfo_name = value; }
		}
		/// <summary>
		/// 教授科目1
		/// </summary>
		public string Teainfo_sub1
		{
			get { return teainfo_sub1; }
			set { teainfo_sub1 = value; }
		}
		/// <summary>
		/// 教授科目2
		/// </summary>
		public string Teainfo_sub2
		{
			get { return teainfo_sub2; }
			set { teainfo_sub2 = value; }
		}
		/// <summary>
		/// 教授科目3
		/// </summary>
		public string Teainfo_sub3
		{
			get { return teainfo_sub3; }
			set { teainfo_sub3 = value; }
		}
		/// <summary>
		/// 教授科目4
		/// </summary>
		public string Teainfo_sub4
		{
			get { return teainfo_sub4; }
			set { teainfo_sub4 = value; }
		}
		/// <summary>
		/// 教授科目5
		/// </summary>
		public string Teainfo_sub5
		{
			get { return teainfo_sub5; }
			set { teainfo_sub5 = value; }
		}
		/// <summary>
		/// 授课学期
		/// </summary>
		public string Teainfo_scheme
		{
			get { return teainfo_scheme; }
			set { teainfo_scheme = value; }
		}

		#endregion

		#region 方法

		/// <summary>
		///返回表名
		/// </summary>
		/// <returns></returns>
		public string GetTableName()
		{
			return "Teainfo";
		}
		/// <summary>
		///返回主键字段名
		/// </summary>
		/// <returns></returns>
		public string GetPkFieldName()
		{
			return "Teainfo_ID";
		}
		/// <summary>
		///返回全路径类名
		/// </summary>
		/// <returns></returns>
		public string GetFullClassName()
		{
			return "labReportSystem.Model.Teainfo";
		}
		/// <summary>
		///返回属性列表
		/// </summary>
		/// <returns></returns>
		public string[] GetAttrNames()
		{
			return new string[]{ "Teainfo_userid", "Teainfo_name", "Teainfo_sub1", "Teainfo_sub2", "Teainfo_sub3", "Teainfo_sub4", "Teainfo_sub5", "Teainfo_scheme" };
		}

		#endregion
	}
}

