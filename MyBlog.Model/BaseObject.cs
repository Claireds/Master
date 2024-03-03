using SqlSugar;
namespace MyBlogModel
{
    public class BaseObject
    {
        [SugarColumn(IsIdentity =true,IsPrimaryKey =true)]      
        public int Id { get; set; }
    }
}
