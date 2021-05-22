using Microsoft.Extensions.Configuration;
using WeTools.SqlSugarDBConfigProvider.Model;
using WeTools.SqlSugarDBConfigProvider.Options;

namespace WeTools.SqlSugarDBConfigProvider
{
    public static class SqlSugarDBConfigExtensions
    {
        /// <summary>
        /// 注册数据库配置源
        /// 需要appsettings配置WeTools节点
        /// 包含ConnectionString（string类型）、ReloadOnChange（bool类型）、ReloadInterval(int类型)、InitTable（bool类型）节点
        /// </summary>
        /// <param name="builder"></param>
        /// <returns></returns>
        public static IConfigurationBuilder AddSqlSugarDBConfiguration(this IConfigurationBuilder builder)
        {
            var configRoot = builder.Build();
            var option = new SqlSugarDBConfigOption();
            configRoot.Bind("WeTools", option);
            return builder.Add(new SqlSugarDBConfigurationSource(option));
        }

        /// <summary>
        /// 注册数据库配置源
        /// 需要appsettings配置WeTools节点
        /// 包含ConnectionString（string类型）、ReloadOnChange（bool类型）、ReloadInterval(int类型)、InitTable（bool类型）节点
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="configService">自主实现数据库访问类</param>
        /// <returns></returns>
        public static IConfigurationBuilder AddSqlSugarDBConfiguration(this IConfigurationBuilder builder, ISqlSugarDBConfigService configService)
        {
            var configRoot = builder.Build();
            var option = new SqlSugarDBConfigOption();
            configRoot.Bind("WeTools", option);
            return builder.Add(new SqlSugarDBConfigurationSource(option, configService));
        }

        /// <summary>
        /// 注册数据库配置源
        /// 需要appsettings配置节点
        /// 包含ConnectionString（string类型）、ReloadOnChange（bool类型）、ReloadInterval(int类型)、InitTable（bool类型）节点
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="option">配置选项</param>
        /// <returns></returns>
        public static IConfigurationBuilder AddSqlSugarDBConfiguration(this IConfigurationBuilder builder, SqlSugarDBConfigOption option)
        {
            return builder.Add(new SqlSugarDBConfigurationSource(option));
        }

        /// <summary>
        /// 注册数据库配置源
        /// 需要appsettings配置节点
        /// 包含ConnectionString（string类型）、ReloadOnChange（bool类型）、ReloadInterval(int类型)、InitTable（bool类型）节点
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="option">配置选项</param>
        /// <param name="configService">自主实现数据库访问类</param>
        /// <returns></returns>
        public static IConfigurationBuilder AddSqlSugarDBConfiguration(this IConfigurationBuilder builder, SqlSugarDBConfigOption option, ISqlSugarDBConfigService configService)
        {
            return builder.Add(new SqlSugarDBConfigurationSource(option, configService));
        }

    }
}
