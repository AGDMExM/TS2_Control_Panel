using Newtonsoft.Json;

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

    private void Button_Save_Clicked(System.Object sender, System.EventArgs e)
    {
        string message = CheckRequiredEntry();
        if (message != null)
        {
            DisplayAlert("Ошибка", $"{message}", "ОK");
            return;
        } 

        var response = TS2_Control_Panel.WebRequest.AddTrigger(GetTriggerFromForm());

        var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content.ReadAsStringAsync().Result);

        if ((bool)result["success"] == true)
        {
            Shell.Current.Navigation.PopAsync();
            return;
        }

        DisplayAlert("Ошибка", $"Триггер не добавлен \n {(string)result["message"]}", "ОK");
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

    private string CheckRequiredEntry()
    {
        string res = new ("");

        if (NameTriggerEntry.Text is null || NameTriggerEntry.Text.Replace(" ", "") == "")
            res += "Name string is empty \n";

        if (ApiKeyEntry.Text is null || ApiKeyEntry.Text.Replace(" ", "") == "")
            res += "API KEY string is empty \n";

        if (ApiSecretEntry.Text is null || ApiSecretEntry.Text.Replace(" ", "") == "")
            res += "API Secret string is empty \n";

        if (ListMoneyEditor.Text is null || ListMoneyEditor.Text.Replace(" ", "") == "")
            res += "Moneys string is empty \n";

        if (MoneyQuoteEntry.Text is null || MoneyQuoteEntry.Text.Replace(" ", "") == "")
            res += "Money quote string is empty \n";

        if (StartTraderExpressionEditor.Text is null || StartTraderExpressionEditor.Text.Replace(" ", "") == "")
            res += "Start Trader Expression string is empty \n";

        if (FilterExpressionEditor.Text is null || FilterExpressionEditor.Text.Replace(" ", "") == "")
            res += "Filter Expression is empty \n";

        if (SortExpressionEditor.Text is null || SortExpressionEditor.Text.Replace(" ", "") == "")
            res += "Sort Expression is empty \n";

        if (LaunchObjectEntry.Text is null || LaunchObjectEntry.Text.Replace(" ", "") == "")
            res += "Launch Object is empty \n";

        if (res == "")
            res = null;

        return res;
    }

    private void Button_ComeBack_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.Navigation.PopAsync();
    }

    /*public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        *//*Settings = (Models.Settings)query["Settings"];
        OnPropertyChanged("Settings");*//*

        IsNewTrigger = (bool)query["isNewTrigger"];
        OnPropertyChanged("isNewTrigger");
    }*/
}