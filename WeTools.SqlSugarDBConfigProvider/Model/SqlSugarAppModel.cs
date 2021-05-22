using SqlSugar;
using WeTools.SqlSugarDBConfigProvider.Helper;

namespace WeTools.SqlSugarDBConfigProvider.Model
{
    [SugarTable("we_app")]
    public class SqlSugarAppModel
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [SugarColumn(ColumnDataType = "varchar(100)")]
        public string Name { get; set; }

        [SugarColumn(ColumnDataType = "varchar(15)")]
        public string IP { get; set; } = "127.0.0.1";

        public string Remark { get; set; }

        public int AddTime { get; set; } = DatetimeHelper.ConvertDateTimeInt();
    }
}
