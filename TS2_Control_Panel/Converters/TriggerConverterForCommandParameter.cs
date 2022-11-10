using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TS2_Control_Panel.Converters
{
    public class TriggerConverterForCommandParameter : IMultiValueConverter
    {

        public object Convert(object[] values, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (values.Length != 2)
                return null;

            if (values[0] is null || values[1] is null)
                return null;

            if (values[1] is object)
                return null;

            Tuple<ObservableCollection<Models.Trigger>, string> tuple = new((ObservableCollection<Models.Trigger>)values[0], (string)values[1]);
            return tuple;
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
