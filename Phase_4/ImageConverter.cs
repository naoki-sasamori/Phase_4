using System;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using System.Globalization;

namespace Phase_4
{
    public class ImageConverter : IValueConverter
    {
        // サムネイルリストボックスに表示するビットマップを作成
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return new BitmapImage(new Uri(value.ToString()));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
