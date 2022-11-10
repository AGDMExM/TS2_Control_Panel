using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace TS2_Control_Panel
{
    public class WebRequest
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string Url = "http://localhost:2031";

        private static HttpResponseMessage Send(string path, Dictionary<string, object> data = null)
        {
            JsonContent content = JsonContent.Create(data);
            
            var result = client.PostAsync(Url + path, content).Result;

            return result;
        }

        private static HttpResponseMessage Get(string path)
        {
            return client.GetAsync(Url + path).Result;
        }

        public static HttpResponseMessage AddTrigger(Models.Trigger trigger)
        {
            var config = new Dictionary<string, object>()
            {
                { "apiKey", trigger.ApiKey },
                { "apiSecret", trigger.ApiSecret },
                { "exchange", trigger.Exchange },
                { "useSandbox", trigger.UseTestnet },
                { "botLimit", trigger.BotLimit },
                { "baseList", trigger.Moneys },
                { "quoteAsset", trigger.MoneyQuote },
                { "listType", trigger.TypeList },
                {
                    "intervals",
                    new Dictionary<string, string>()
                    {
                        { "indicatorCalculate", trigger.IndicatorCalculationPeriod.ToString() },
                        { "updateList", trigger.PeriodUpdatingMarketData.ToString() }
                    }
                },
                { "volumeFilter", trigger.MinimumTradingVolume },
                { "triggerExpression", trigger.StartTraderExpression },
                { "filterExpression", trigger.FilterExpression },
                { "sortExpression", trigger.SortExpression },
                { "sortType", trigger.SortType },
                { "action", trigger.Action },
                { "target", trigger.LaunchObject }
            };

            var data = new Dictionary<string, object>()
            {
                { "trigger", trigger.Name },
                { "config", config }
            };

            return Send("/triggers/addTrigger", data);
        }

        public static HttpResponseMessage GetTriggersDictionary()
        {
            return Get("/triggers/getTriggers");
        }

        public static HttpResponseMessage DeleteTrigger(string name)
        {
            var data = new Dictionary<string, object>()
            {
                { "trigger", name }
            };

            return Send("/triggers/deleteTrigger", data);
        }
    }
}
