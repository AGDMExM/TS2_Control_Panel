using System.Text.Json;
using TS2_Control_Panel.Pages;
using TS2_Control_Panel.Resources.Styles;
using TS2_Control_Panel.Models;

namespace TS2_Control_Panel;

public partial class App : Application
{
    //public Models.Settings Settings { get; set; }

/*    public Command SwitchToTriggerPageCommand { get; set; } = new Command(() =>
    {
        var navigationParameter = new Dictionary<string, object>
            {
                { "Settings", false }
            };
        Shell.Current.GoToAsync($"CreateNewTriggerPage", navigationParameter);
    });*/

    public App()
	{
        /*        var set = new Models.Settings()
        {
            Servers = new List<Server>()
            {
                
            },

            Triggers = new List<Trigger>()
            {
                new Trigger(
                    "Name1", "ApiKey", "ApiSecret", "exchange", 
                    "market", false, "money", "quote",
                    "typeList", 3000, 360000, 10000, "startExpression", 
                    "filterExpression", "sortExpression",
                    "sortType", 10, "action", "launchObject")
            },

            Exchanges = new List<string>()
            {
                "Binance"
            },
            Markets = new List<string>()
            {
                "Futures"
            },
            Moneys = new List<string>()
            {
                "BTC",
                "ETH",
                "BNB",
                "SOL"
            },
            MoneyQuotes = new List<string>()
            {
                "USDT"
            },
            ListTypes = new List<string>()
            {
                "Белый",
                "Чёрный"
            },
            DefaultIndicatorCalculationPeriod = 3000,
            DefaultPeriodUpdatingMarketData = 3600000,
            DefaultMinimumTradingVolume = 1000000,
            DefaultStartTraderExpression = "RSI('5m', 14) < 40 and RSI('15m', 14) < 50 and RSI('1h', 14) < 55",
            DefaultFilterExpression = "volatility('5m', 10) < 2.0",
            DefaultSortExpression = "volatility('5m', 10)",
            SortTypes = new List<string>()
            {
                "По убыванию",
                "По возрастанию"
            },
            DefaultBotLimit = 1,
            Actions = new List<string>()
            {
                "Запустить"
            },
            DefaultLaunchObject = "Target"
        };
        string pathSettings = string.Join('\\', AppDomain.CurrentDomain.BaseDirectory.Split('\\')[0..7]);

        using (FileStream fs = new FileStream(pathSettings + "\\settings.json", FileMode.OpenOrCreate))
        {
            var options = new JsonSerializerOptions() { WriteIndented = true };
            JsonSerializer.Serialize<Models.Settings>(fs, set, options);
        }*/

        /*string pathSettings = string.Join('\\', AppDomain.CurrentDomain.BaseDirectory.Split('\\')[0..7]);
        Settings = Models.Settings.ReadSettings(pathSettings + "\\settings.json");*/
        InitializeComponent();

        //App.Current.UserAppTheme = AppTheme.Light;

        Routing.RegisterRoute(nameof(CreateNewTriggerPage), typeof(CreateNewTriggerPage));
    }


}
