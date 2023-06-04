using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DigiSort_Box.Front_end
{
    public partial class LoadingForm : Form
    {
        private readonly int totalProgressSteps = 100; // Adjust this value based on the desired progress granularity
        private int currentProgressStep = 0;
        private System.ComponentModel.BackgroundWorker loadingBackgroundWorker;

        public LoadingForm()
        {
            InitializeComponent();

            // Set up the background worker
            loadingBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            loadingBackgroundWorker.WorkerReportsProgress = true;
            loadingBackgroundWorker.DoWork += backgroundWorker_DoWork;
            loadingBackgroundWorker.ProgressChanged += backgroundWorker_ProgressChanged;
            loadingBackgroundWorker.RunWorkerCompleted += backgroundWorker_RunWorkerCompleted;
        }

        private void LoadingForm_Shown(object sender, EventArgs e)
        {
            // Start the background worker
            loadingBackgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Perform initialization tasks or time-consuming operations
            // ...

            // Simulate progress
            while (currentProgressStep < totalProgressSteps)
            {
                // Perform a portion of the initialization task
                // ...

                // Update the progress
                currentProgressStep++;

                // Report the progress to the UI thread
                int progressPercentage = (int)((float)currentProgressStep / totalProgressSteps * 100);
                loadingBackgroundWorker.ReportProgress(progressPercentage);

                // Simulate a delay to show the progress
                System.Threading.Thread.Sleep(100); // Adjust the delay based on your preference
            }
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progress bar value
            progressBar.Value = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Hide the loading screen
            Hide();

            Forms.DigiSortBox dg = new Forms.DigiSortBox();
            dg.Show();
        }
    }
}


