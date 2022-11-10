using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace TS2_Control_Panel.Models
{
    public class Trigger : INotifyPropertyChanged, ICloneable
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; }

        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }

        public string Exchange { get; set; }
        public bool UseTestnet { get; set; }

        /// <summary>
        /// Money separated ','
        /// </summary>
        public List<string> Moneys { get; set; }
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

        public Trigger() { }

        public Trigger(
            string name, string apiKey, string apiSecret, string exchange, 
            bool useTestnet, List<string> moneys, string moneyQuote, 
            string typeList, long indicatorCalculationPeriod, long periodUpdatingMarketData, 
            long minimumTradingVolume, string startTraderExpression, string filterExpression, 
            string sortExpression, string sortType, int botLimit, string action, string launchObject)
        {
            Name = name;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Exchange = exchange;
            UseTestnet = useTestnet;
            Moneys = moneys;
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

        public static List<Trigger> GetTriggersFromDictionaryAPI(Dictionary<string, object> triggersDict)
        {
            if (triggersDict is null) 
                return null;

            List<Trigger> res = new(); 
            foreach (string name in triggersDict.Keys)
            {
                var config = (triggersDict[name] as JObject).ToObject<Dictionary<string, object>>();
                var intervals = (config["intervals"] as JObject).ToObject<Dictionary<string, object>>();
                res.Add(new Trigger(
                    name,
                    (string)config["apiKey"],
                    (string)config["apiSecret"],
                    (string)config["exchange"],
                    (bool)config["useSandbox"],
                    (config["baseList"] as List<string>),
                    (string)config["quoteAsset"],
                    (string)config["listType"],
                    Convert.ToInt64(intervals["indicatorCalculate"]),
                    Convert.ToInt64(intervals["updateList"]),
                    Convert.ToInt64(config["volumeFilter"]),
                    (string)config["triggerExpression"],
                    (string)config["filterExpression"],
                    (string)config["sortExpression"],
                    (string)config["sortType"],
                    Convert.ToInt32(config["botLimit"]),
                    (string)config["action"],
                    (string)config["target"]));
            }

            return res;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
