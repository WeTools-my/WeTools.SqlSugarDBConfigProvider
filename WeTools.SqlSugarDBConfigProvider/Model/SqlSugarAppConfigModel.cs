using SqlSugar;
using WeTools.SqlSugarDBConfigProvider.Helper;

namespace WeTools.SqlSugarDBConfigProvider.Model
{
    [SugarTable("we_app_config")]
    public class SqlSugarAppConfigModel
    {
        [SugarColumn(IsIdentity = true, IsPrimaryKey = true)]
        public int Id { get; set; }

        [SugarColumn(ColumnDataType = "varchar(300)")]
        public string Name { get; set; }

        [SugarColumn(ColumnDataType = "varchar(3000)")]
        public string Value { get; set; }

        [SugarColumn(IndexGroupNameList = new string[] { "appid" })]
        public int AppId { get; set; } = 0;

        [SugarColumn(IsIgnore =true)]
        public string AppName { get; set; }

        [SugarColumn(IsIgnore = true)]
        public string IP { get; set; } = "127.0.0.1";

        public int AddTime { get; set; } = DatetimeHelper.ConvertDateTimeInt();
    }
}
