using MyBlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyBlog.Model
{
    public class User:BaseObject
    {
        [SugarColumn(ColumnDataType ="nvarchar(10)")]
        public string Name {  get; set; }
        /// <summary>
        /// 用户名
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(10)")]
        public string UserName { get; set; }
        /// <summary>
        /// 密码MD5
        /// </summary>
        [SugarColumn(ColumnDataType = "nvarchar(10)")]
        public string Password { get; set; }
    }
}
