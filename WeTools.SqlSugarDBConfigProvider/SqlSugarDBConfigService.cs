using System.Collections.Generic;
using WeTools.SqlSugarDBConfigProvider.Model;
using WeTools.SqlSugarDBConfigProvider.Options;

namespace WeTools.SqlSugarDBConfigProvider
{
    public class SqlSugarDBConfigService : DbContext<SqlSugarAppConfigModel>, ISqlSugarDBConfigService
    {
        public SqlSugarDBConfigService(SqlSugarDBConfigOption option) : base(option) { }

        public List<SqlSugarAppConfigModel> GetConfigs()
        {
            return db.Queryable<SqlSugarAppConfigModel>().ToList();
        }

        public void InitTable()
        {
            db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(SqlSugarAppModel));
            db.CodeFirst.SetStringDefaultLength(200).InitTables(typeof(SqlSugarAppConfigModel));
        }

        public List<SqlSugarAppConfigModel> GetConfigsByAppName(string appName)
        {
            var data = db.Queryable<SqlSugarAppConfigModel, SqlSugarAppModel>((ac, app) => ac.AppId == app.Id)
                         .Where((ac, app) => app.Name.Contains(appName))
                         .Select((ac, app) => new SqlSugarAppConfigModel { 
                             Id = ac.Id, 
                             Name = ac.Name, 
                             Value = ac.Value, 
                             AppId = app.Id, 
                             AppName = app.Name, 
                             AddTime = ac.AddTime, 
                             IP = app.IP
                         })
                         .ToList();

            return data;
        }
    }
}
