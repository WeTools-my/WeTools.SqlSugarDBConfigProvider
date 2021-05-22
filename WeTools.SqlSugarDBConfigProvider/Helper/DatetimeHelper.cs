using System;

namespace WeTools.SqlSugarDBConfigProvider.Helper
{
    class DatetimeHelper
    {
        /// <summary>  
        /// Unix时间戳转为C#格式时间  
        /// </summary>  
        /// <param name="timeStamp">Unix时间戳格式,例如1482115779</param>  
        /// <returns>C#格式时间</returns>  
        public static DateTime GetTime(string timeStamp)
        {
            
            DateTime dtStart = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }


        /// <summary>  
        /// DateTime时间格式转换为Unix时间戳格式  
        /// </summary>  
        /// <param name="time"> DateTime时间格式</param>  
        /// <returns>Unix时间戳格式</returns>  
        public static int ConvertDateTimeInt(DateTime time)
        {
            System.DateTime startTime = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        /// <summary>  
        /// DateTime时间格式转换为Unix时间戳格式  
        /// </summary>  
        /// <param name="time"> DateTime时间格式</param>  
        /// <returns>Unix时间戳格式</returns>  
        public static int ConvertDateTimeInt()
        {
            var time = DateTime.Now;
            System.DateTime startTime = TimeZoneInfo.ConvertTimeToUtc(new DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }
    }
}
