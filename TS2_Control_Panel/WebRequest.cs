using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Net.Http.Json;

namespace TS2_Control_Panel
{
    public class WebRequest
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string Url = "http://localhost:2031";

        private static async Task<HttpResponseMessage> Send(string path, Dictionary<string, object> data)
        {
            JsonContent content = JsonContent.Create(data);
            
            var response = await client.PostAsync(Url + path, content);
            //Person? person = await response.Content.ReadFromJsonAsync<Person>();

            return response;
        }

        public static Task<HttpResponseMessage> AddTrigger(Models.Trigger trigger)
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
    }
}
