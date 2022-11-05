using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

        //public ObservableCollection<Trigger> Triggers { get; set; } = new();

        public Models.Settings Settings { get; set; }

        public Command AddNewTriggerCommand { get; set; } = new Command(() =>
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "isNewTrigger", true }
            };
            Shell.Current.GoToAsync($"CreateNewTriggerPage", navigationParameter);
        });

        public TriggerViewModel() 
        { 

        }

        public TriggerViewModel(Models.Settings settings) 
        {
            Settings = settings;
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
