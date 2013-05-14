using System;
using System.ComponentModel;
using System.Net;
using System.Windows;

namespace MetadataDesktopUtil
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private readonly BackgroundWorker worker = new BackgroundWorker();

        public MainWindow()
        {
            InitializeComponent();
            worker.DoWork += new DoWorkEventHandler(FixMetadataWorker);
            worker.ProgressChanged += new ProgressChangedEventHandler(UpdateWorkerProgress);
            worker.WorkerReportsProgress = true;
        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            worker.RunWorkerAsync(new [] {ServerUrlTextBox.Text, UuidTextBox.Text});
        }

        private void UpdateWorkerProgress(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            Log.Info("Updating progress: " + progressChangedEventArgs.ProgressPercentage);
            Dispatcher.BeginInvoke((Action)(() => ProgressBar1.Value = progressChangedEventArgs.ProgressPercentage));
            UpdateStatus((string)progressChangedEventArgs.UserState);
            
        }

        private void FixMetadataWorker(object sender, DoWorkEventArgs eventArgs)
        {
            ServicePointManager.Expect100Continue = false;


            UpdateStatus("Startet!");
            DisableStartButton();
            string[] args = (string[]) eventArgs.Argument;
            var serverUrl = args[0];
            var uuid = args[1];

            
            if (string.IsNullOrEmpty(uuid))
            {
                MetadataFixerService metadataFixerService = new MetadataFixerService(serverUrl, worker);
                metadataFixerService.SearchForAllEntries();
            }
            else
            {
                var metadataFixer = new MetadataFixer(serverUrl);
                metadataFixer.FixMetadataEntry(new MetadataEntry { Title = "unknown", Uuid = uuid});
            }
            
            EnableStartButton();
            

            UpdateStatus("Ferdig!");
        }

        private void DisableStartButton()
        {
            Dispatcher.Invoke((Action)(() => StartButton.IsEnabled = false));
        }

        private void EnableStartButton()
        {
            Dispatcher.Invoke((Action)(() => StartButton.IsEnabled = true));
        }

        private void UpdateStatus(string statusText)
        {
            Dispatcher.Invoke((Action) (() => StatusLabel.Content = statusText));
        }

    }
}
