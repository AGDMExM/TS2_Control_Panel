using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using TS2_Control_Panel.Models;

namespace TS2_Control_Panel
{
    public class CreateNewTriggerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ValuesForBindingTriggerPage ValuesForInterface { get; set; }

/*        public Command SaveTriggerCommand { get; set; } = new Command(() =>
        {
            Debug.WriteLine("Exit Page New Trigger Command");

            

            //Shell.Current.Navigation.PopAsync();

            *//*var navigationParameter = new Dictionary<string, object>
            {
                { "isNewTrigger", true }
            };
            Shell.Current.GoToAsync($"CreateNewTriggerPage", navigationParameter);*//*
        });*/

        public CreateNewTriggerViewModel()
        {
            ValuesForInterface = ValuesForBindingTriggerPage.ReadJson();
        }

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
