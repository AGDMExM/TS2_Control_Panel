using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TS2_Control_Panel.Models
{
    public class Settings
    {
        public List<Server> Servers { get; set; }
        public List<Trigger> Triggers { get; set; }

        // For Trigger Page
        public List<string> Exchanges { get; set; }
        public List<string> Markets { get; set; }
        public List<string> Moneys { get; set; }
        public List<string> MoneyQuotes { get; set; }
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

        public static Settings ReadSettings(string path)
        {
            Settings settings = new Settings();
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    settings = JsonSerializer.Deserialize<Settings>(fs);
                }
            }
            catch (Exception ex)
            {
                var pathToLog = string.Join('\\', path.Split('\\').ToList().Remove(path.Split('\\').Last()));
                using (FileStream fs = new FileStream(pathToLog + "\\log_" + DateTime.Now.ToString(), FileMode.OpenOrCreate))
                {
                    byte[] buffer = Encoding.Default.GetBytes(ex.Message);
                    fs.Write(buffer, 0, buffer.Length);
                }
            }

            return settings;
        }
    }
}
