using System;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace SmsManagerWindowsApp
{
    public partial class Form1 : Form
    {
        private readonly System.Timers.Timer _sampleTimer;

        public Form1()
        {
            InitializeComponent();

            _sampleTimer = new System.Timers.Timer
            {
                Interval = 5000
            };
            _sampleTimer.Elapsed += DoWorkAndUpdateUIAsync;
        }

        private async void DoWorkAndUpdateUIAsync(object sender, EventArgs e)
        {
            var result = await DoWorkAsync();
            ReadSmsServiceStatusLabel.Text = result;
        }

        private async Task<string> DoWorkAsync()
        {
            await Task.Delay(1000);
            return DateTime.Now.Ticks.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void ReadSmsServiceButton_Click(object sender, EventArgs e)
        {
            _sampleTimer.Start();
            StartReaderService();
        }


        private void StopReadServiceButton_Click(object sender, EventArgs e)
        {
            _sampleTimer.Stop();
            StopReaderService();
        }

        private void StopReaderService()
        {
            ReadSmsServiceStatusLabel.Text = "متوقف";
            ReadSmsServiceButton.Enabled = true;
            StopReadServiceButton.Enabled = false;
        }

        private void StartReaderService()
        {
            ReadSmsServiceStatusLabel.Text = "در حال اجرا";
            ReadSmsServiceButton.Enabled = false;
            StopReadServiceButton.Enabled = true;
        }

        
    }
}
