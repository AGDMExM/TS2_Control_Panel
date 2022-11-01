using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TS2_Control_Panel.Settings;

namespace TS2_Control_Panel.FlyoutPageItems
{
    internal class AddNewTriggerFlyoutPageItems
    {
        private DefaultSettings _settings;

        private static readonly LayoutOptions ALIGN_CENTER = LayoutOptions.Center;
        private static readonly LayoutOptions ALIGN_LEFT = LayoutOptions.Start;

        public Label MainLabel = new Label();

        // base
        public Label NameTriggelLabel = new();
        public Entry NameTriggerEntry = new();

        // api
        public Label ApiKeyLabel = new();
        public Entry ApiKeyEntry = new();
        public Label ApiSecretLabel = new();
        public Entry ApiSecretEntry = new();

        // exchange
        public Label ExchangeLabel = new();
        public Picker ExchangePicker = new();
        public Label MarketLabel = new();
        public Picker MarketPicker = new();
        public Label UseTestnetLabel = new();
        public CheckBox UseTestnetCheckBox = new();

        // money
        public Label MoneyLabel = new();
        public Editor MoneyEditor = new();
        public Label MoneyQuoteLabel = new();
        public Entry MoneyQuoteEntry = new();
        public Label TypeListLabel = new();
        public Picker TypeListPicker = new();

        // period
        public Label IndicatorCalculationPeriodLabel = new();
        public Entry IndicatorCalculationPeriodEntry = new();
        public Stepper IndicatorCalculationPeriodStepper = new();
        public Label PeriodUpdatingMarketDataLabel = new();
        public Entry PeriodUpdatingMarketDataEntry = new();
        public Stepper PeriodUpdatingMarketDataStepper = new();

        // expression
        public Label MinimumTradingVolumeLabel = new();
        public Entry MinimumTradingVolumeEntry = new();
        public Stepper MinimumTradingVolumeStepper = new();
        public Label StartTraderExpressionLabel = new();
        public Editor StartTraderExpressionEditor = new();
        public Label FilterExpressionLabel = new();
        public Editor FilterExpressionEditor = new();
        public Label SortExpressionLabel = new();
        public Editor SortExpressionEditor = new();
        public Label SortTypeLabel = new();
        public Picker SortTypePicker = new();

        // bot
        public Label BotLimitLabel = new();
        public Entry BotLimitEntry = new();
        public Stepper BotLimitStepper = new();

        // actions
        public Label ActionLabel = new();
        public Picker ActionPicker = new();

        public Label LaunchObjectLabel = new();
        public Entry LaunchObjectEntry = new();

        public Button SaveButton = new();

        public AddNewTriggerFlyoutPageItems(DefaultSettings settings)
        {
            _settings = settings;
            SetElementSetting();
            SetActions();
            SetDefaultValues();
        }

        private void SetElementSetting()
        {
            var textColor = Colors.Black;
            var fontSize = 14;
            var pickerColor = Colors.Gray;
            var stepperColor = Colors.Gray;

            MainLabel.HorizontalOptions = ALIGN_CENTER;
            MainLabel.TextColor = textColor;
            MainLabel.FontSize = 20;

            // base
            NameTriggelLabel.TextColor = textColor;
            NameTriggelLabel.FontSize = fontSize;
            NameTriggerEntry.TextColor = textColor;
            NameTriggerEntry.FontSize = fontSize;

            // api
            ApiKeyLabel.TextColor = textColor;
            ApiKeyLabel.FontSize = fontSize;
            ApiKeyEntry.TextColor = textColor;
            ApiKeyEntry.FontSize = fontSize;

            ApiSecretLabel.TextColor = textColor;
            ApiSecretLabel.FontSize = fontSize;
            ApiSecretEntry.TextColor = textColor;
            ApiSecretEntry.FontSize = fontSize;

            // exchange
            ExchangeLabel.TextColor = textColor;
            ExchangeLabel.FontSize = fontSize;
            ExchangePicker.TextColor = textColor;
            ExchangePicker.FontSize = fontSize;

            MarketLabel.TextColor = textColor;
            MarketLabel.FontSize = fontSize;
            MarketPicker.TextColor = textColor;
            MarketPicker.FontSize = fontSize;

            UseTestnetLabel.TextColor = textColor;
            UseTestnetLabel.FontSize = fontSize;

            // money
            MoneyLabel.TextColor = textColor;
            MoneyLabel.FontSize = fontSize;
            MoneyEditor.TextColor = textColor;
            MoneyEditor.FontSize = fontSize;

            MoneyQuoteLabel.TextColor = textColor;
            MoneyQuoteLabel.FontSize = fontSize;
            MoneyQuoteEntry.TextColor = textColor;
            MoneyQuoteEntry.FontSize = fontSize;

            TypeListLabel.TextColor = textColor;
            TypeListLabel.FontSize = fontSize;
            TypeListPicker.TextColor = textColor;
            TypeListPicker.FontSize = fontSize;

            // period
            IndicatorCalculationPeriodLabel.TextColor = textColor;
            IndicatorCalculationPeriodLabel.FontSize = fontSize;
            IndicatorCalculationPeriodEntry.TextColor = textColor;
            IndicatorCalculationPeriodEntry.FontSize = fontSize;
            IndicatorCalculationPeriodStepper.BackgroundColor = stepperColor;
            IndicatorCalculationPeriodStepper.Maximum = long.MaxValue;

            PeriodUpdatingMarketDataLabel.TextColor = textColor;
            PeriodUpdatingMarketDataLabel.FontSize = fontSize;
            PeriodUpdatingMarketDataEntry.TextColor = textColor;
            PeriodUpdatingMarketDataEntry.FontSize = fontSize;
            PeriodUpdatingMarketDataStepper.BackgroundColor = stepperColor;
            PeriodUpdatingMarketDataStepper.Maximum = long.MaxValue;

            // expression
            MinimumTradingVolumeLabel.TextColor = textColor;
            MinimumTradingVolumeLabel.FontSize = fontSize;
            MinimumTradingVolumeEntry.TextColor = textColor;
            MinimumTradingVolumeEntry.FontSize = fontSize;
            MinimumTradingVolumeStepper.BackgroundColor = stepperColor;
            MinimumTradingVolumeStepper.Maximum = long.MaxValue;

            StartTraderExpressionLabel.TextColor = textColor;
            StartTraderExpressionLabel.FontSize = fontSize;
            StartTraderExpressionEditor.TextColor = textColor;
            StartTraderExpressionEditor.FontSize = fontSize;

            FilterExpressionLabel.TextColor = textColor;
            FilterExpressionLabel.FontSize = fontSize;
            FilterExpressionEditor.TextColor = textColor;
            FilterExpressionEditor.FontSize = fontSize;

            SortExpressionLabel.TextColor = textColor;
            SortExpressionLabel.FontSize = fontSize;
            SortExpressionEditor.TextColor = textColor;
            SortExpressionEditor.FontSize = fontSize;

            SortTypeLabel.TextColor = textColor;
            SortTypeLabel.FontSize = fontSize;
            SortTypePicker.TextColor = textColor;
            SortTypePicker.FontSize = fontSize;

            // bot
            BotLimitLabel.TextColor = textColor;
            BotLimitLabel.FontSize = fontSize;
            BotLimitEntry.TextColor = textColor;
            BotLimitEntry.FontSize = fontSize;
            BotLimitStepper.BackgroundColor = stepperColor;
            BotLimitStepper.Maximum = int.MaxValue;

            // actions
            ActionLabel.TextColor = textColor;
            ActionLabel.FontSize = fontSize;
            ActionPicker.TextColor = textColor;
            ActionPicker.FontSize = fontSize;
            LaunchObjectLabel.TextColor = textColor;
            LaunchObjectLabel.FontSize = fontSize;
            LaunchObjectEntry.TextColor = textColor;
            LaunchObjectEntry.FontSize = fontSize;

            // button
            SaveButton.TextColor = textColor;
            SaveButton.FontSize = fontSize;
            SaveButton.BackgroundColor = Colors.Gray;



            /*            DefaultSettings.SetDefaultElementSetting(MainLabel);

                        // base
                        DefaultSettings.SetDefaultElementSetting(NameTriggelLabel);
                        DefaultSettings.SetDefaultElementSetting(NameTriggerEntry);

                        // api
                        DefaultSettings.SetDefaultElementSetting(ApiKeyLabel);
                        DefaultSettings.SetDefaultElementSetting(ApiKeyEntry);
                        DefaultSettings.SetDefaultElementSetting(ApiSecretLabel);
                        DefaultSettings.SetDefaultElementSetting(ApiSecretEntry);

                        // exchange
                        DefaultSettings.SetDefaultElementSetting(ExchangeLabel);
                        DefaultSettings.SetDefaultElementSetting(ExchangePicker);
                        DefaultSettings.SetDefaultElementSetting(MarketLabel);
                        DefaultSettings.SetDefaultElementSetting(MarketPicker);
                        DefaultSettings.SetDefaultElementSetting(UseTestnetLabel);
                        DefaultSettings.SetDefaultElementSetting(UseTestnetCheckBox);

                        // money
                        DefaultSettings.SetDefaultElementSetting(MoneyLabel);
                        DefaultSettings.SetDefaultElementSetting(MoneyEditor);
                        DefaultSettings.SetDefaultElementSetting(MoneyQuoteLabel);
                        DefaultSettings.SetDefaultElementSetting(MoneyQuoteEntry);
                        DefaultSettings.SetDefaultElementSetting(TypeListLabel);
                        DefaultSettings.SetDefaultElementSetting(TypeListPicker);

                        // period
                        DefaultSettings.SetDefaultElementSetting(IndicatorCalculationPeriodLabel);
                        DefaultSettings.SetDefaultElementSetting(IndicatorCalculationPeriodStepper);
                        DefaultSettings.SetDefaultElementSetting(PeriodUpdatingMarketDataLabel);
                        DefaultSettings.SetDefaultElementSetting(PeriodUpdatingMarketDataStepper);

                        // expression
                        DefaultSettings.SetDefaultElementSetting(MinimumTradingVolumeLabel);
                        DefaultSettings.SetDefaultElementSetting(MinimumTradingVolumeStepper);
                        DefaultSettings.SetDefaultElementSetting(StartTraderExpressionLabel);
                        DefaultSettings.SetDefaultElementSetting(StartTraderExpressionEditor);
                        DefaultSettings.SetDefaultElementSetting(FilterExpressionLabel);
                        DefaultSettings.SetDefaultElementSetting(FilterExpressionEditor);
                        DefaultSettings.SetDefaultElementSetting(SortExpressionLabel);
                        DefaultSettings.SetDefaultElementSetting(SortExpressionEditor);
                        DefaultSettings.SetDefaultElementSetting(SortTypeLabel);
                        DefaultSettings.SetDefaultElementSetting(SortTypePicker);

                        // bot
                        DefaultSettings.SetDefaultElementSetting(BotLimitLabel);
                        DefaultSettings.SetDefaultElementSetting(BotLimitStepper);

                        // actions
                        DefaultSettings.SetDefaultElementSetting(ActionLabel);
                        DefaultSettings.SetDefaultElementSetting(ActionPicker);
                        DefaultSettings.SetDefaultElementSetting(LaunchObjectLabel);
                        DefaultSettings.SetDefaultElementSetting(LaunchObjectEntry);*/
        }

        private void SetDefaultValues()
        {
            MainLabel.Text = _settings.DefaultName;

            // base
            NameTriggelLabel.Text = "Имя триггера";
            NameTriggerEntry.Placeholder = "Имя триггера";

            // api
            ApiKeyLabel.Text = "API Key";
            ApiKeyEntry.Placeholder = "API Key";
            ApiSecretLabel.Text = "API Secret";
            ApiSecretEntry.Placeholder = "API Secret";

            // exchange
            ExchangeLabel.Text = "Биржа";
            ExchangePicker.ItemsSource = _settings.ExchangesList;
            ExchangePicker.SelectedIndex = 0;
            MarketLabel.Text = "Маркет";
            MarketPicker.ItemsSource = _settings.MarketList;  
            MarketPicker.SelectedIndex = 0;
            UseTestnetLabel.Text = "Использовать тестнет";
            UseTestnetCheckBox.IsChecked = true;

            // money
            MoneyLabel.Text = "Список монет";
            //MoneyEditor.Placeholder = string.Join(',', _settings.MoneyList);
            MoneyEditor.Text = string.Join(',', _settings.MoneyList);
            MoneyQuoteLabel.Text = "Монета квоты";
            //MoneyQuoteEntry.Placeholder = string.Join('/', _settings.MoneyQuoteList); 
            MoneyQuoteEntry.Text = string.Join('/', _settings.MoneyQuoteList);
            TypeListLabel.Text = "Тип списка";
            TypeListPicker.ItemsSource = _settings.ListTypes;
            TypeListPicker.SelectedIndex = 0;

            // period
            IndicatorCalculationPeriodLabel.Text = "Период рассчёта индикаторов (миллисекунды)";
            IndicatorCalculationPeriodStepper.Value = _settings.DefaultIndicatorCalculationPeriod;
            PeriodUpdatingMarketDataLabel.Text = "Период обновления данных маркета (миллисекунды)";
            PeriodUpdatingMarketDataStepper.Value = _settings.DefaultPeriodUpdatingMarketData;

            // expression
            MinimumTradingVolumeLabel.Text = "Минимальный объём торгов";
            MinimumTradingVolumeStepper.Value = _settings.DefaultMinimumTradingVolume;
            StartTraderExpressionLabel.Text = "Выражение для старта трейдера";
            //StartTraderExpressionEditor.Placeholder = _settings.DefaultStartTraderExpression;
            StartTraderExpressionEditor.Text = _settings.DefaultStartTraderExpression;
            FilterExpressionLabel.Text = "Выражение фильтра";
            //FilterExpressionEditor.Placeholder = _settings.DefaultFilterExpression;
            FilterExpressionEditor.Text = _settings.DefaultFilterExpression;
            SortExpressionLabel.Text = "Выражение сортировки";
            //SortExpressionEditor.Placeholder = _settings.DefaultSortExpression;
            SortExpressionEditor.Text = _settings.DefaultSortExpression;
            SortTypeLabel.Text = "Тип сортировки";
            SortTypePicker.ItemsSource = _settings.SortTypes;
            SortTypePicker.SelectedIndex = 0;

            // bot
            BotLimitLabel.Text = "Лимит ботов";
            BotLimitStepper.Value = _settings.DefaultBotLimit;

            // actions
            ActionLabel.Text = "Действие";
            ActionPicker.ItemsSource = _settings.Actions;
            ActionPicker.SelectedIndex = 0;

            LaunchObjectLabel.Text = "Объект запуска";
            LaunchObjectEntry.Placeholder = "Target";

            // button
            SaveButton.Text = "Сохранить";
        }

        private void SetActions()
        {
            IndicatorCalculationPeriodEntry.TextChanged += IndicatorCalculationPeriodEntry_OnTextChanged;
            IndicatorCalculationPeriodStepper.ValueChanged += IndicatorCalculationPeriodStepper_OnValueChanged;

            PeriodUpdatingMarketDataEntry.TextChanged += PeriodUpdatingMarketDataEntry_OnTextChanged;
            PeriodUpdatingMarketDataStepper.ValueChanged += PeriodUpdatingMarketDataStepper_OnValueChanged;

            MinimumTradingVolumeEntry.TextChanged += MinimumTradingVolumeEntry_OnTextChanged;
            MinimumTradingVolumeStepper.ValueChanged += MinimumTradingVolumeStepper_OnValueChanged;

            BotLimitEntry.TextChanged += BotLimitEntry_OnTextChanged;
            BotLimitStepper.ValueChanged += BotLimitStepper_OnValueChanged;

            //SaveButton.Clicked += SaveButton_OnClicked;
        }

        private void IndicatorCalculationPeriodEntry_OnTextChanged(object sender, EventArgs e)
        {
            FromEntryToStepperValue(IndicatorCalculationPeriodEntry, IndicatorCalculationPeriodStepper);
        }

        private void PeriodUpdatingMarketDataEntry_OnTextChanged(object sender, EventArgs e)
        {
            FromEntryToStepperValue(PeriodUpdatingMarketDataEntry, PeriodUpdatingMarketDataStepper);
        }

        private void MinimumTradingVolumeEntry_OnTextChanged(object sender, EventArgs e)
        {
            FromEntryToStepperValue(MinimumTradingVolumeEntry, MinimumTradingVolumeStepper);
        }

        private void BotLimitEntry_OnTextChanged(object sender, EventArgs e)
        {
            FromEntryToStepperValue(BotLimitEntry, BotLimitStepper);
        }

        private void IndicatorCalculationPeriodStepper_OnValueChanged(object sender, EventArgs e)
        {
            FromStepperToEntryValue(IndicatorCalculationPeriodStepper, IndicatorCalculationPeriodEntry);
        }

        private void PeriodUpdatingMarketDataStepper_OnValueChanged(object sender, EventArgs e)
        {
            FromStepperToEntryValue(PeriodUpdatingMarketDataStepper, PeriodUpdatingMarketDataEntry);
        }

        private void MinimumTradingVolumeStepper_OnValueChanged(object sender, EventArgs e)
        {
            FromStepperToEntryValue(MinimumTradingVolumeStepper, MinimumTradingVolumeEntry);
        }

        private void BotLimitStepper_OnValueChanged(object sender, EventArgs e)
        {
            FromStepperToEntryValue(BotLimitStepper, BotLimitEntry);
        }


        private void FromStepperToEntryValue(Stepper stepper, Entry entry)
        {
            entry.Text = stepper.Value.ToString();
        }

        private void FromEntryToStepperValue(Entry entry, Stepper stepper) 
        {
            stepper.Value = Convert.ToDouble(entry.Text);
        }

        private void SaveButton_OnClicked(object sender, EventArgs e)
        {
            throw new Exception();
        }

        public VerticalStackLayout GetVerticalStackLayoutFromElements(int horizontalSize)
        {
            var verticalStackLayout = new VerticalStackLayout()
            {
                WidthRequest = horizontalSize
            };

            verticalStackLayout.Add(MainLabel);

            // base
            verticalStackLayout.Add(NameTriggelLabel);
            verticalStackLayout.Add(NameTriggerEntry);

            // api
            verticalStackLayout.Add(ApiKeyLabel);
            verticalStackLayout.Add(ApiKeyEntry);
            verticalStackLayout.Add(ApiSecretLabel);
            verticalStackLayout.Add(ApiSecretEntry);

            // exchange
            verticalStackLayout.Add(ExchangeLabel);
            verticalStackLayout.Add(ExchangePicker);
            verticalStackLayout.Add(MarketLabel);
            verticalStackLayout.Add(MarketPicker);
            verticalStackLayout.Add(
                new HorizontalStackLayout()
                {
                    UseTestnetCheckBox,
                    UseTestnetLabel
                });

            // money
            verticalStackLayout.Add(MoneyLabel);
            verticalStackLayout.Add(MoneyEditor);
            verticalStackLayout.Add(MoneyQuoteLabel);
            verticalStackLayout.Add(MoneyQuoteEntry);
            verticalStackLayout.Add(TypeListLabel);
            verticalStackLayout.Add(TypeListPicker);

            // period
            verticalStackLayout.Add(IndicatorCalculationPeriodLabel);
            verticalStackLayout.Add(
                new HorizontalStackLayout()
                {
                    IndicatorCalculationPeriodEntry,
                    IndicatorCalculationPeriodStepper
                });
            verticalStackLayout.Add(PeriodUpdatingMarketDataLabel);
            verticalStackLayout.Add(
                new HorizontalStackLayout()
                {
                    PeriodUpdatingMarketDataEntry,
                    PeriodUpdatingMarketDataStepper
                });

            // expression
            verticalStackLayout.Add(MinimumTradingVolumeLabel);
            verticalStackLayout.Add(
                new HorizontalStackLayout()
                {
                    MinimumTradingVolumeEntry,
                    MinimumTradingVolumeStepper
                });
            verticalStackLayout.Add(StartTraderExpressionLabel);
            verticalStackLayout.Add(StartTraderExpressionEditor);
            verticalStackLayout.Add(FilterExpressionLabel);
            verticalStackLayout.Add(FilterExpressionEditor);
            verticalStackLayout.Add(SortExpressionLabel);
            verticalStackLayout.Add(SortExpressionEditor);
            verticalStackLayout.Add(SortTypeLabel);
            verticalStackLayout.Add(SortTypePicker);

            // bot
            verticalStackLayout.Add(BotLimitLabel);
            verticalStackLayout.Add(
                new HorizontalStackLayout()
                {
                    BotLimitEntry,
                    BotLimitStepper
                });

            // actions
            verticalStackLayout.Add(ActionLabel);
            verticalStackLayout.Add(ActionPicker);

            verticalStackLayout.Add(LaunchObjectLabel);
            verticalStackLayout.Add(LaunchObjectEntry);

            
            verticalStackLayout.Add(SaveButton);

            return verticalStackLayout;
        }
    }
}
