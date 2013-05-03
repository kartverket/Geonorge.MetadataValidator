using System.Windows;

namespace MetadataDesktopUtil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StatusLabel.Content = "Startet";
            MetadataFixerService metadataFixerService = new MetadataFixerService(ServerUrlTextBox.Text);
            metadataFixerService.SearchForAllEntries();
            StatusLabel.Content = "Ferdig!";
        }

    }
}
