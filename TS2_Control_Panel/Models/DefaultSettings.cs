using Microsoft.Maui.Graphics;
using Microsoft.Maui.Graphics.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TS2_Control_Panel.Settings
{
    public class DefaultSettings
    {
        public static readonly List<string> DEFAULT_SERVER_LIST = new List<string>()
        {
            "Сервера",
            "Добавить сервер"
        };
        public static readonly List<string> DEFAULT_EDITOR_LIST = new List<string>()
        {
            "Редактор",
            "Редактор триггеров",
            "Редактор трейдеров"
        };
        public static readonly List<string> DEFAULT_UTILITIES_LIST = new List<string>()
        {
            "Утилиты",
            "Конструктор сетки",
            "Конструктор условий"
        };

        public List<string> ServerList { get; set; }
        public List<string> EditorList { get; set; }
        public List<string> UtilitiesList { get; set; }

        // For Trigger
        public string DefaultName { get; set; }
        //public string DefaultApiKey { get; set; }
        //public string DefaultApiSecret { get; set; }
        public List<string> ExchangesList { get; set; }
        public List<string> MarketList { get; set; }
        public List<string> MoneyList { get; set; }
        public List<string> MoneyQuoteList { get; set; }
        public List<string> ListTypes { get; set; }
        public long DefaultIndicatorCalculationPeriod { get; set; }
        public long DefaultPeriodUpdatingMarketData { get; set; }
        public long DefaultMinimumTradingVolume { get; set; }
        public string DefaultStartTraderExpression { get; set; }
        public string DefaultFilterExpression { get; set; }
        public string DefaultSortExpression { get; set; }
        public List<string> SortTypes { get; set; }
        public int DefaultBotLimit { get; set; }
        public List<string> Actions { get; set; }
        public string DefaultLaunchObject { get; set; }
    }
}
