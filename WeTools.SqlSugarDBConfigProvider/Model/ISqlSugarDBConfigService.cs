using System.Collections.Generic;

namespace WeTools.SqlSugarDBConfigProvider.Model
{
    /// <summary>
    /// 后端服务配置
    /// </summary>
    public interface ISqlSugarDBConfigService
    {
        /// <summary>
        /// 获取应用的所有配置
        /// </summary>
        /// <param name="appName">应用名称</param>
        /// <returns></returns>
        List<SqlSugarAppConfigModel> GetConfigsByAppName(string appName);

        /// <summary>
        /// 获取应用的所有配置
        /// </summary>
        /// <returns></returns>
        List<SqlSugarAppConfigModel> GetConfigs();

        /// <summary>
        /// 初始化表
        /// </summary>
        void InitTable();
    }
}
