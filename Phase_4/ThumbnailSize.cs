using System;
using System.Windows.Data;
using System.Globalization;

namespace Phase_4
{
    public class ThumbnailSize : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // 「サムネイルサイズ」スライダーバーの値により、テキストブロックに設定する値を決定
            switch ((double)value)
            {
                case 1:
                    return "Small";
                case 2:
                default:
                    return "Middle";
                case 3:
                    return "Large";
            }
        }

            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}