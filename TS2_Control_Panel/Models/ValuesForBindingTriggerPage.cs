using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TS2_Control_Panel.Models
{
    public class ValuesForBindingTriggerPage
    {
        public List<Dictionary<string, string>> Exchanges { get; set; }
        public string Moneys { get; set; }
        public string QuoteMoney { get; set; }
        public List<Dictionary<string, string>> ListTypes { get; set; }
        public string StartTradedrExpression { get; set; }
        public string FilterExpression { get; set; }
        public string SortExpression { get; set; }
        public List<Dictionary<string, string>> SortTypes { get; set; }
        public List<Dictionary<string, string>> Actions { get; set; }

        public static ValuesForBindingTriggerPage ReadJson(string path = null)
        {
            if (path is null)
                path = string.Join('\\', AppDomain.CurrentDomain.BaseDirectory.Split('\\')[0..7]) + "\\DefaultValuesForTriggerPage.json";

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {                
                return JsonSerializer.Deserialize<ValuesForBindingTriggerPage>(fs);
            }
        }
    }
}
