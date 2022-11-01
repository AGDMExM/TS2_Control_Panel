using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS2_Control_Panel
{
    public class Trigger
    {
        public string Name { get; set; }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

        public string Exchange { get; set; }
        public string Market { get; set; }
        public bool UseTestnet { get; set; }

        /// <summary>
        /// Money separated ','
        /// </summary>
        public string Money { get; set; }
        public string MoneyQuote { get; set; }
        public string TypeList { get; set; }

        /// <summary>
        /// Milliseconds
        /// </summary>
        public long IndicatorCalculationPeriod { get; set; }
        /// <summary>
        /// Milliseconds
        /// </summary>
        public long PeriodUpdatingMarketData { get; set; }

        public long MinimumTradingVolume { get; set; }
        public string StartTraderExpression { get; set; }
        public string FilterExpression { get; set; }
        public string SortExpression { get; set; }
        public string SortType { get; set; }

        public int BotLimit { get; set; }

        public string Action { get; set; }
        public string LaunchObject { get; set; }

        public Trigger(
            string name, string apiKey, string apiSecret, string exchange, 
            string market, bool useTestnet, string money, string moneyQuote, 
            string typeList, long indicatorCalculationPeriod, long periodUpdatingMarketData, 
            long minimumTradingVolume, string startTraderExpression, string filterExpression, 
            string sortExpression, string sortType, int botLimit, string action, string launchObject)
        {
            Name = name;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Exchange = exchange;
            Market = market;
            UseTestnet = useTestnet;
            Money = money;
            MoneyQuote = moneyQuote;
            TypeList = typeList;
            IndicatorCalculationPeriod = indicatorCalculationPeriod;
            PeriodUpdatingMarketData = periodUpdatingMarketData;
            MinimumTradingVolume = minimumTradingVolume;
            StartTraderExpression = startTraderExpression;
            FilterExpression = filterExpression;
            SortExpression = sortExpression;
            SortType = sortType;
            BotLimit = botLimit;
            Action = action;
            LaunchObject = launchObject;
        }
    }
}
