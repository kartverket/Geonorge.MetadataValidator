using System;
using System.ComponentModel;
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
            worker.RunWorkerAsync(ServerUrlTextBox.Text);
        }

        private void UpdateWorkerProgress(object sender, ProgressChangedEventArgs progressChangedEventArgs)
        {
            Log.Info("Updating progress: " + progressChangedEventArgs.ProgressPercentage);
            Dispatcher.BeginInvoke((Action)(() => ProgressBar1.Value = progressChangedEventArgs.ProgressPercentage));
            
            
        }

        private void FixMetadataWorker(object sender, DoWorkEventArgs eventArgs)
        {
            UpdateStatus("Startet!");
            DisableStartButton();
            MetadataFixerService metadataFixerService = new MetadataFixerService((string)eventArgs.Argument, worker);
            metadataFixerService.SearchForAllEntries();
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
