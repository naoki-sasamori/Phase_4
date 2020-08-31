using System;
using System.IO;
using System.Linq;      // Selectに必要
using System.Windows;


// フォルダー選択ダイアログの名前空間を using
using Forms = System.Windows.Forms;

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

        // --------------------------------------------------
        // フォルダー参照ダイアログボックスを表示
        // --------------------------------------------------
        private void buttonOpen_Click(object sender, RoutedEventArgs e)
        {
            // フォルダー参照ダイアログのインスタンスを生成
            var dlg = new Forms.FolderBrowserDialog();

            dlg.Description = "フォルダーを選択してください";

            // フォルダー参照ダイアログを表示
            if ( dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK ) {

                // パスをテキストボックスに表示
                this.filePath.Text = dlg.SelectedPath;

                // 指定フォルダー内にあるファイルの名称(パス含む)を取得
                var files = Directory.GetFiles(dlg.SelectedPath);
                var images = files.Select(f => new ImageFolder() { Image = f }).ToList();
                DataContext = images;
            }
        }

        // --------------------------------------------------
        // アプリケーション処理開始時
        // --------------------------------------------------
        private void Windows_Loaded(object sender, EventArgs e)
        {
            // ウィンドウに関する設定値を取得
            LoadWindowsInfo();
        }

        // --------------------------------------------------
        // アプリケーション終了時
        // --------------------------------------------------
        private void Windows_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // ウィンドウに関する設定値を保持
            SaveWiodowsInfo();
        }

        // --------------------------------------------------
        // ウィンドウに関する設定値を取得
        // --------------------------------------------------
        private void LoadWindowsInfo()
        {
            var settings = Properties.Settings.Default;

            this.filePath.Text = settings.filePath;

            if ( settings.WindowLeft >= 0 && (settings.WindowLeft + settings.WindowWidth) < SystemParameters.VirtualScreenWidth ) {
                this.Left = settings.WindowLeft;
            }

            if ( settings.WindowTop >= 0 && (settings.WindowTop + settings.WindowHeight) < SystemParameters.VirtualScreenHeight ) {
                this.Top = settings.WindowTop;
            }

            if ( settings.WindowWidth > 0 && settings.WindowWidth <= SystemParameters.WorkArea.Width ) {
                this.Width = settings.WindowWidth;
            }

            if ( settings.WindowHeight > 0 && settings.WindowHeight <= SystemParameters.WorkArea.Height ) {
                this.Height = settings.WindowHeight;
            }

            if ( settings.WindowMaximized ) {
                // ロード後に最大化
                this.WindowState = WindowState.Maximized;
            }
        }

        // --------------------------------------------------
        // ウィンドウに関する設定値を保持
        // --------------------------------------------------
        private void SaveWiodowsInfo()
        {
            var settings = Properties.Settings.Default;

            settings.filePath           = this.filePath.Text;
            settings.WindowMaximized    = this.WindowState == WindowState.Maximized;
            settings.WindowLeft         = this.Left;
            settings.WindowTop          = this.Top;
            settings.WindowWidth        = this.Width;
            settings.WindowHeight       = this.Height;
            settings.Save();
        }
    }
}
