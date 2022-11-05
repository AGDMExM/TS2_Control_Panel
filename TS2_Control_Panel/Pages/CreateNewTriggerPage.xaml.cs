using System.Diagnostics;
using System.Text.Json;

namespace TS2_Control_Panel.Pages;

//[QueryProperty(nameof(IsNewTrigger), "IsNewTrigger")]
public partial class CreateNewTriggerPage : ContentPage//, IQueryAttributable
{
    //public Models.Settings Settings { get; set; }
    //public bool IsNewTrigger { get; private set; }
    



    /*public static readonly BindableProperty IsNewTrigger = BindableProperty.Create(
        nameof(IsNewTrigger), 
        typeof(bool), 
        typeof(CreateNewTriggerPage), 
        false);*/

    public CreateNewTriggerPage()
	{
        InitializeComponent();
        ExchangePicker.SelectedIndex = 0;
        TypeListPicker.SelectedIndex = 1;
        SortTypePicker.SelectedIndex = 0;
        ActionPicker.SelectedIndex = 0;
    }

    /*public CreateNewTriggerPage(Models.Settings settings)
    {
        Settings = settings;
        InitializeComponent();
    }*/

    /*    public CreateNewTriggerPage(bool isNewTrigger)
        {
            IsNewTrigger = isNewTrigger;
            InitializeComponent();
        }*/

    private void SaveButton_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("SaveTrigger Command");
        var response = TS2_Control_Panel.WebRequest.AddTrigger(GetTriggerFromForm());
        Debug.WriteLine(response.Result);
    }

    private Models.Trigger GetTriggerFromForm()
    {
        return new Models.Trigger(
            NameTriggerEntry.Text,
            ApiKeyEntry.Text,
            ApiSecretEntry.Text,
            (ExchangePicker.SelectedItem as Dictionary<string, string>)["val"],
            UseTesstnetCheckBox.IsChecked,
            ListMoneyEditor.Text.Split(',').ToList(),
            MoneyQuoteEntry.Text,
            (TypeListPicker.SelectedItem as Dictionary<string, string>)["val"],
            (long)IndicatorCalculationPeriodStepper.Value,
            (long)PeriodUpdatingMarketDataStepper.Value,
            (long)MinimumTradingVolumeStepper.Value,
            StartTraderExpressionEditor.Text,
            FilterExpressionEditor.Text,
            SortExpressionEditor.Text,
            (SortTypePicker.SelectedItem as Dictionary<string, string>)["val"],
            (int)BotLimitStepper.Value,
            (ActionPicker.SelectedItem as Dictionary<string, string>)["val"],
            LaunchObjectEntry.Text);
    }

    /*public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        *//*Settings = (Models.Settings)query["Settings"];
        OnPropertyChanged("Settings");*//*

        IsNewTrigger = (bool)query["isNewTrigger"];
        OnPropertyChanged("isNewTrigger");
    }*/
}