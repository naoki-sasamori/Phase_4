using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Phase_4
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // アプリケーション処理開始時
        private void Windows_ContentRendered(object sender, EventArgs e)
        {
            // テキストボックスに前回の値を設定
            filePath.Text = Properties.Settings.Default.filePath;

            // ウィンドウに関する設定値を取得
            LoadWiodowsInfo();
        }

        // アプリケーション終了時
        private void Windows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // テキストボックスの値を保存
            Properties.Settings.Default.filePath = filePath.Text;
            Properties.Settings.Default.Save();

            // ウィンドウに関する設定値を保持
            SaveWiodowsInfo();
        }

        // ウィンドウに関する設定値を取得
        private void LoadWiodowsInfo()
        {
            var settings = Properties.Settings.Default;

            if ( settings.WindowLeft >= 0 && (settings.WindowLeft + settings.WindowWidth) < SystemParameters.VirtualScreenWidth ) {
                Left = settings.WindowLeft;
            }

            if ( settings.WindowTop >= 0 && (settings.WindowTop + settings.WindowHeight) < SystemParameters.VirtualScreenHeight ) {
                Top = settings.WindowTop;
            }

            if ( settings.WindowWidth > 0 && settings.WindowWidth <= SystemParameters.WorkArea.Width ) {
                Width = settings.WindowWidth;
            }

            if ( settings.WindowHeight > 0 && settings.WindowHeight <= SystemParameters.WorkArea.Height ) {
                Height = settings.WindowHeight;
            }

            if ( settings.WindowMaximized ) {
                // ロード後に最大化
                WindowState = WindowState.Maximized;
            }
        }

        // ウィンドウに関する設定値を保持
        private void SaveWiodowsInfo()
        {
            var settings = Properties.Settings.Default;
            settings.WindowMaximized    = WindowState == WindowState.Maximized;
            settings.WindowLeft         = Left;
            settings.WindowTop          = Top;
            settings.WindowWidth        = Width;
            settings.WindowHeight       = Height;
            settings.Save();
        }
    }
}
