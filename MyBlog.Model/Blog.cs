using MyBlogModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace MyBlog.Model
{
    public class Blog:BaseObject
    {
        [SugarColumn(ColumnDataType ="nvarchar(20)")]
        public string Title {  get; set; }
        [SugarColumn(ColumnDataType = "text")]
        public string Content { get; set; }
        public DateTime CreateTme { get; set; }

        public int WriterId { get; set; }
        public int TypeId { get; set; }
        public int BrowsNum { get; set; }
        public int LikeNum { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        [SugarColumn(IsIgnore = true)]
        public TypeInfo TypeInfo { get; set; }
        /// <summary>
        /// 作者
        /// </summary>
        [SugarColumn(IsIgnore =true)]
        public User User { get; set; }
    }
}
