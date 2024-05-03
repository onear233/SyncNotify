using System.Windows.Controls;

namespace SyncNotify.Pages.DiaglogPages
{
    /// <summary>
    /// HistoryPage.xaml 的交互逻辑
    /// </summary>
    public partial class HistoryPage : iNKORE.UI.WPF.Modern.Controls.Page
    {
        //需要一个settings对象
        public static Settings settings = new Settings();

        public HistoryPage()
        {
            InitializeComponent();
            //把本页面的settings对象进行赋值
            settings = SettingsManager.GetSettingsByFile(Settings.settingsFileName, settings);
            displayHistoryMessage();
        }

        private void displayHistoryMessage()
        {
            NotificationFileManager notificationFileManager = new NotificationFileManager();
            string[] messageContent = notificationFileManager.ReadTop10TxtFiles(settings.General.FolderLocation);

        }
    }
}
