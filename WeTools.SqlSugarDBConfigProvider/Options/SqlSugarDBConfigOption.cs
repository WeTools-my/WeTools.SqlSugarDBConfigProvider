namespace WeTools.SqlSugarDBConfigProvider.Options
{
    /// <summary>
    /// 配置提供者选项
    /// </summary>
    public class SqlSugarDBConfigOption
    {
        /// <summary>
        /// 连接字符串
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// 后台配置的应用名称，根据此项查询配置
        /// </summary>
        public string AppName { get; set; }

        /// <summary>
        /// 是否重载
        /// </summary>
        public bool ReloadOnChange { get; set; } = false;

        /// <summary>
        /// 重载间隔
        /// </summary>
        public int ReloadInterval { get; set; } = 3;

        ///// <summary>
        ///// 配置源 0 json 文件，1 数据库
        ///// </summary>
        //public int ConfigSource { get; set; } = 1;

        /// <summary>
        /// 数据库类型,与sqlsugar 类型一致，默认0
        /// MySql = 0,
        ///SqlServer = 1,
        ///Sqlite = 2,
        ///Oracle = 3,
       /// PostgreSQL = 4,
       /// Dm = 5,
       /// Kdbndp = 6
        /// </summary>
        public int DatabaseType { get; set; }

        /// <summary>
        /// 是否初始化表
        /// </summary>
        public bool InitTable { get; set; } = true;
    }
}
