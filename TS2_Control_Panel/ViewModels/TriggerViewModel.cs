using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TS2_Control_Panel.Pages;

namespace TS2_Control_Panel
{
    public class TriggerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<Models.Trigger> Triggers { get; set; } = new();

        public Command AddNewTriggerCommand { get; set; } = new Command(() =>
        {
/*            var navigationParameter = new Dictionary<string, object>
            {
                        { "isNewTrigger", true }
            };
            Shell.Current.GoToAsync($"CreateNewTriggerPage", navigationParameter);*/
            Shell.Current.GoToAsync($"CreateNewTriggerPage");
            
        });

        public Command DeleteTriggerCommand { get; set; } = new Command<Models.Trigger>((trigger) =>
        {
            return;
            Shell.Current.GoToAsync($"CreateNewTriggerPage");
        });

        public Command RefreshTriggersCommand { get; set; } = new Command<ObservableCollection<Models.Trigger>>((triggers) =>
        {
            triggers.Clear();

            var response = TS2_Control_Panel.WebRequest.GetTriggersDictionary();
            var result = JsonConvert.DeserializeObject<
                Dictionary<string, object>>(response.Content.ReadAsStringAsync().Result);

            if (!(bool)result["success"])
                return;

            var triggersDict = (result["triggers"] as JObject).ToObject<Dictionary<string, object>>();

            foreach (var el in Models.Trigger.GetTriggersFromDictionaryAPI(triggersDict))
                triggers.Add(el);
        });

        public TriggerViewModel() 
        {
            RefreshTriggersCommand.Execute(Triggers);
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
