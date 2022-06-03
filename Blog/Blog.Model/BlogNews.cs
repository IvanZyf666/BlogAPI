using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
namespace Blog.Model
{
    public class BlogNews:BaseId
    {
        // nvarchar has good chinese support
        [SugarColumn(ColumnDataType = "nvarchar(30)")]
        public string Title { get; set; }
        [SugarColumn(ColumnDataType = "text")]
        public string Content { get; set; }
        public DateTime Time { get; set; }
        public int BrowseCount { get; set; }
        public int LikeCount { get; set; }
        public int AuthorId { get; set; }
        /// <summary>
        /// type, not mapping to database
        /// </summary>
        public int TypeId { get; set; }

        [SugarColumn(IsIgnore = true)]
        public AuthorInfo AuthorInfo { get; set; }
        [SugarColumn(IsIgnore = true)]
        public TypeInfo TypeInfo { get; set; }
    }
}
