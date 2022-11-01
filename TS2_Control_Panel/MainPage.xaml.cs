using System;
using System.Diagnostics;
using System.Text;
using System.Text.Json;
using TS2_Control_Panel.FlyoutPageItems;
using TS2_Control_Panel.Settings;

namespace TS2_Control_Panel;

public partial class MainPage : ContentPage
{
    private readonly DefaultSettings DEFAULT_SETTINGS;
    public MainPage()
    {
        InitializeComponent();

        /*var set = new DefaultSettings()
        {
            ServerList = new List<string>() 
            {
                "Сервера",
                "Добавить сервер"
            },

            EditorList = new List<string>()
            {
                "Редактор",
                "Редактор триггеров",
                "Редактор трейдеров"
            },
            UtilitiesList = new List<string>()
            {
                "Утилиты",
                "Конструктор сетки",
                "Конструктор условий"
            },

            DefaultName = "Добавление нового триггера",
            //DefaultApiKey = ;
            //DefaultApiSecret;
            ExchangesList = new List<string>()
            {
                "Binance"
            },
            MarketList = new List<string>()
            {
                "Futures"
            },
            MoneyList = new List<string>()
            {
                "BTC",
                "ETH",
                "BNB",
                "SOL"
            },
            MoneyQuoteList = new List<string>()
            {
                "USDT"
            },
            ListTypes = new List<string>()
            {
                "Белый",
                "Чёрный"
            },
            DefaultIndicatorCalculationPeriod = 3000,
            DefaultPeriodUpdatingMarketData = 3600000,
            DefaultMinimumTradingVolume = 1000000,
            DefaultStartTraderExpression = "RSI('5m', 14) < 40 and RSI('15m', 14) < 50 and RSI('1h', 14) < 55",
            DefaultFilterExpression = "volatility('5m', 10) < 2.0",
            DefaultSortExpression = "volatility('5m', 10)",
            SortTypes = new List<string>()
            {
                "По убыванию",
                "По возрастанию"
            },
            DefaultBotLimit = 1,
            Actions = new List<string>()
            {
                "Запустить"
            },
            DefaultLaunchObject = "Target"
        };
        string pathSettings = string.Join('\\', AppDomain.CurrentDomain.BaseDirectory.Split('\\')[0..7]);
        
        using (FileStream fs = new FileStream(pathSettings + "\\settings.json", FileMode.OpenOrCreate))
        {
            var options = new JsonSerializerOptions() { WriteIndented = true };
            JsonSerializer.Serialize<DefaultSettings>(fs, set, options);
        }*/

        string pathSettings = string.Join('\\', AppDomain.CurrentDomain.BaseDirectory.Split('\\')[0..7]);
        DEFAULT_SETTINGS = ReadSettings(pathSettings + "\\settings.json");

        if (DEFAULT_SETTINGS is null)
            return;

        serverPicker.ItemsSource = DEFAULT_SETTINGS.ServerList;
        serverPicker.SelectedIndex = 0;

        editorPicker.ItemsSource = DEFAULT_SETTINGS.EditorList;
        editorPicker.SelectedIndex = 0;

        utilitiesPicker.ItemsSource = DEFAULT_SETTINGS.UtilitiesList;
        utilitiesPicker.SelectedIndex = 0;

        RemoveAllChildrenFromLayout(mainVerticalStack, 1);
    }

    private DefaultSettings ReadSettings(string path)
    {
        DefaultSettings defaultSettings = new DefaultSettings();
        try
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                defaultSettings = JsonSerializer.Deserialize<DefaultSettings>(fs);
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

        return defaultSettings;
    }

    private void HomeButton_OnClicked(object sender, EventArgs e)
    {
        
    }

    private void IndicatorButton_OnClicked(object sender, EventArgs e)
    {

    }

    private void StatisticButton_OnClicked(object sender, EventArgs e)
    {

    }

    private void SettingsButton_OnClicked(object sender, EventArgs e)
    {

    }

    private void LogButton_OnClicked(object sender, EventArgs e)
    {

    }

    private void ServerPickerSelectedIndexChanged(object sender, EventArgs e)
	{
        var picker = sender as Picker;

        // Nothing selected
        if ((string)picker.SelectedItem == DEFAULT_SETTINGS.ServerList[0]) // "Servers"
            return;

        if ((string)picker.SelectedItem == DEFAULT_SETTINGS.ServerList[1]) // "Add new server"
            return;

        // Refresh interface on current server
        // _currentServer = ______ class Server {name, adress, port}
    }

    private void EditorPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = sender as Picker;

        if ((string)picker.SelectedItem == DEFAULT_SETTINGS.EditorList[0]) // "Editors"
            return;

        if ((string)picker.SelectedItem == DEFAULT_SETTINGS.EditorList[1]) // "Add Trigger"
        {
            RemoveAllChildrenFromLayout(mainVerticalStack, 1);
            SetMainViewForAddTrigger();
            return;
        }

    }

    private void UtilitiesPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = sender as Picker;
        string nameItem = picker.SelectedItem as string;

        // Nothing selected
        if (nameItem == DEFAULT_SETTINGS.UtilitiesList[0]) // "Editor"
            return;

        if (nameItem == DEFAULT_SETTINGS.UtilitiesList[1]) // "Grid Editor"
            SetGridLayoutOnGridEditor();

        //if (nameItem == DEFAULT_SETTINGS.UtilitiesList[2])
        //    return;
    }

    private void SetGridLayoutOnGridEditor()
    {
/*        var grid = gridMainPage;
        grid.ColumnDefinitions.Clear();
        grid.RowDefinitions.Clear();

        for (int i=0; i < 4; i++)
            grid.RowDefinitions.Add(new RowDefinition());
        for (int i = 0; i < 2; i++)
            grid.ColumnDefinitions.Add(new ColumnDefinition());


        grid.Add(this.LoadFromXaml("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n" +
                "<ContentPage xmlns=\"http://schemas.microsoft.com/dotnet/2021/maui\"\n" +
                "xmlns:x=\"http://schemas.microsoft.com/winfx/2009/xaml\"\n" +
                "x:Class=\"HelloApp.StartPage\">\n" +
                "<Label Text=\"Hello METANIT.COM\" FontSize=\"22\" />" +
                "</ContentPage>"), 1, 0);*/
        /*var labelCountOrder = new Label();
        labelCountOrder.Name
        grid.Add(
            new VerticalStackLayout().Add(
                new Label(), 
            0, 0);*/
    }

    private void RemoveAllChildrenFromLayout(Layout layout, int startPosition = 0)
    {
        for (int i=startPosition; i < layout.Children.Count; i++)   // in this moment i = 1, cause' child with pos(i) = 1 it's top menu
        {
            var child = layout[i];
            if (child is Layout)
            {
                RemoveAllChildrenFromLayout(child as Layout);
                i--;
            }
                
            layout.Children.Remove(child);
        }
    }

    private void SetMainViewForAddTrigger()
    {
        var button_NewTrigger = new Button
        {
            Text = "Добавить новый триггер",
            HorizontalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.LightGray, 
            TextColor = Colors.Black
        };
        button_NewTrigger.Clicked += AddNewTrigger;

        mainVerticalStack.Add(button_NewTrigger);
    }

    private void AddNewTrigger(object sender, EventArgs e)
    {
        SetMainViewForFormNewTrigger();
    }

    private void SetMainViewForFormNewTrigger()
    {
        RemoveAllChildrenFromLayout(mainVerticalStack, 1);
        var elementsPageNewTrigger = new AddNewTriggerFlyoutPageItems(DEFAULT_SETTINGS);
        elementsPageNewTrigger.SaveButton.Clicked += NewTriggerSaveButton_OnClicked;

        var scroll = new ScrollView
        {
            Orientation = ScrollOrientation.Vertical,
            HeightRequest = this.Height, 
            Content = elementsPageNewTrigger.GetVerticalStackLayoutFromElements(500)
        };
        
        mainVerticalStack.Add(scroll);
    }

    // ИЛИ вынести это в форму нового триггера и передавать туда объект триггера
    private void NewTriggerSaveButton_OnClicked(object sender, EventArgs e)
    {
        throw new Exception();
    }

}

