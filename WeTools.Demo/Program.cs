using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeTools.SqlSugarDBConfigProvider;
using WeTools.SqlSugarDBConfigProvider.Model;
using WeTools.SqlSugarDBConfigProvider.Options;

namespace WeTools.Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(configBuilder =>
            {
                //configBuilder.AddSqlSugarDBConfiguration();
                //ISqlSugarDBConfigService pro = new SqlSugarDBConfigService(new DbOption { ConnectionString = "host=localhost;port=3306;user id=root;password=;database=sugar;", DatabaseType = 0 });
                //configBuilder.AddSqlSugarDBConfiguration(pro);

                var configRoot = configBuilder.Build();
                var option = new SqlSugarDBConfigOption();
                configRoot.Bind("WeTools", option);

                ISqlSugarDBConfigService pro = new SqlSugarDBConfigService(option);

                configBuilder.AddSqlSugarDBConfiguration(option,pro);

            })
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                });
    }
}
