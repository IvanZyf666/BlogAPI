using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;
namespace Blog.Model
{
    public class AuthorInfo:BaseId
    {
        [SugarColumn(ColumnDataType = "nvarchar(12)")]
        public string Name { get; set; }
        [SugarColumn(ColumnDataType = "nvarchar(16)")]
        public string UserName { get; set; }
        // long pwd for encryption
        [SugarColumn(ColumnDataType = "nvarchar(64)")]
        public string UserPwd { get; set; }

    }
}
