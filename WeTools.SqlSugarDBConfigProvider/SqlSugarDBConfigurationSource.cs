using Microsoft.Extensions.Configuration;
using WeTools.SqlSugarDBConfigProvider.Model;
using WeTools.SqlSugarDBConfigProvider.Options;

namespace WeTools.SqlSugarDBConfigProvider
{
    class SqlSugarDBConfigurationSource : IConfigurationSource
    {
        private readonly SqlSugarDBConfigOption _option;
        private readonly ISqlSugarDBConfigService _configService;
        public SqlSugarDBConfigurationSource(SqlSugarDBConfigOption option)
        {
            _option = option;
        }

        public SqlSugarDBConfigurationSource(SqlSugarDBConfigOption option, ISqlSugarDBConfigService configService)
        {
            _option = option;
            _configService = configService;
        }

        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            var obj = _configService == null ? new SqlSugarDBConfigurationProvider(_option) : new SqlSugarDBConfigurationProvider(_option, _configService);
            return obj;
        }
    }
}
