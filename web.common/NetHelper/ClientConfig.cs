
using System;
using System.Configuration;
namespace ola.lottery.Helper
{
    /// <summary>
    /// 客户端全局配置
    /// </summary>
    public class ClientConfig
    {
        public static string BaseHost { get; set; }

        private static string baseAddress;

        public static string BaseAddress
        {
            get
            {
                if (string.IsNullOrEmpty(baseAddress))
                {
                    baseAddress = ConfigurationManager.AppSettings["baseAddress"];
                }
                return ClientConfig.baseAddress;
            }
            set { ClientConfig.baseAddress = value; }
        }
        /// <summary>
        /// AccessKey失效后重复请求次数
        /// </summary>
        public static int RepeatRequestTimes = 1;

        /// <summary>
        /// 持续获取开奖号码的间隔时间
        /// </summary>
        public static TimeSpan GetOpenResultSecond = TimeSpan.FromSeconds(10);

        /// <summary>
        /// 持续获取下期信息的时间间隔
        /// </summary>
        public static TimeSpan GetNextLotteryOpenInfoSecond = TimeSpan.FromSeconds(10);

    }
}
