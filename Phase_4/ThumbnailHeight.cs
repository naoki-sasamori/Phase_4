using System;
using System.Windows.Data;
using System.Globalization;

namespace Phase_4
{
    public class ThumbnailHeight : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 「サムネイルサイズ」スライダーバーの値により、イメージに表示する高を決定
            switch ((double)value)
            {
                case 1:
                    return 50;
                case 2:
                default:
                    return 100;
                case 3:
                    return 150;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}