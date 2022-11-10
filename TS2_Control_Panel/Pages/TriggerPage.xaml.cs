using Microsoft.Maui.Controls.Internals;
using Newtonsoft.Json;

namespace TS2_Control_Panel.Pages;

public partial class TriggerPage : ContentPage
{
	public TriggerPage()
    {
        InitializeComponent();
    }

    private void Button_AddNewTrigger_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync($"CreateNewTriggerPage");
    }

    private void Button_EditTrigger_Clicked(System.Object sender, System.EventArgs e)
    {
        
    }

    private async void Button_DeleteTrigger_Clicked(System.Object sender, System.EventArgs e)
    {
        Models.Trigger currentTrigger = ((ImageButton)sender).BindingContext as Models.Trigger;
        
        var message = $"������� ������� {currentTrigger.Name}?";
        bool deletionConfirmed = await DisplayAlert("�������������", message, "��", "���");
        
        if (!deletionConfirmed)
            return;

        var response = TS2_Control_Panel.WebRequest.DeleteTrigger(currentTrigger.Name);

        var result = JsonConvert.DeserializeObject<Dictionary<string, object>>(response.Content.ReadAsStringAsync().Result);

        if ((bool)result["success"] == true)
        {
            // �������, � ��������� �� ��������
            //(triggersListView.ItemsSource as List<Models.Trigger>).Remove(currentTrigger);
            return;
        }

        await DisplayAlert("������", $"������� �� �������� \n {(string)result["message"]}", "�K");
    }

    /*    public TriggerPage(DeviceListVm vm) : base(vm, "Devices")
        {
            InitializeComponent();

            BindingContext = new TriggerViewModel(settings);
        }*/
    /*    public TriggerPage(Models.Settings settings)
        {
            InitializeComponent();

            BindingContext = new TriggerViewModel(settings);
        }*/
}