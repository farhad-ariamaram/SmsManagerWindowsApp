using SmsManagerWindowsApp.Models;
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.IO.Ports;
using System.Text;
using SmsManagerWindowsApp.Utilities;
using System.Net;
using System.IO;

namespace SmsManagerWindowsApp
{
    public partial class Form1 : Form
    {
        private readonly System.Timers.Timer _sampleTimer;
        private readonly EmployDBContext _context;

        public Form1()
        {
            InitializeComponent();

            _context = new EmployDBContext();

            _sampleTimer = new System.Timers.Timer
            {
                Interval = 5000
            };
            _sampleTimer.Elapsed += DoWorkAndUpdateUIAsync;
        }

        private async void DoWorkAndUpdateUIAsync(object sender, EventArgs e)
        {
            //var result = await DoWorkAsync();
            //ReadSmsServiceStatusLabel.Text = result;
            
        }

        private async Task DoWorkAsync()
        {
            try
            {
                string portNo;
                SerialPort serialPort = new SerialPort();

                //Get port name from "app.config" file
                portNo = System.Configuration.ConfigurationManager.AppSettings["MP"];

                //Config GSM modem
                serialPort.PortName = portNo;
                serialPort.BaudRate = 9600;

                //Open Port
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                }

                //Change read language to UCS2 text
                serialPort.WriteLine("AT+CSCS=\"UCS2\"");
                Thread.Sleep(2000);

                //Read received messages
                string output = "";
                serialPort.WriteLine("AT" + System.Environment.NewLine);
                Thread.Sleep(2000);
                serialPort.WriteLine("AT+CMGF=1\r" + System.Environment.NewLine);
                Thread.Sleep(2000);
                serialPort.WriteLine("AT+CMGL=\"REC UNREAD\"" + System.Environment.NewLine);
                Thread.Sleep(5000);
                output = serialPort.ReadExisting();

                //Convert received messages to an string array by each line, receivedMessages[i] means line i-th from all received messaages
                string[] receivedMessages = null;
                receivedMessages = output.Split(new[] { Environment.NewLine }, StringSplitOptions.None);

                //Loop for analyze each line of received messages
                for (int i = 0; i < receivedMessages.Length - 1; i++)
                {
                    if (receivedMessages[i].StartsWith("+CMGL"))
                    {
                        string[] message = receivedMessages[i].Split(',');

                        //Read phone number from raw UCS2 text and convert it to normal text
                        string ph = null;
                        string phone = null;
                        ph = message[2].Replace("\"", string.Empty);
                        StringBuilder sb2 = new StringBuilder();
                        for (int j = 0; j < ph.Length; j += 4)
                        {
                            sb2.AppendFormat("\\u{0:x4}", ph.Substring(j, 4));
                        }
                        phone = System.Text.RegularExpressions.Regex.Unescape(sb2.ToString()).Replace("\"", string.Empty);

                        //Read text message from raw UCS2 text and convert it to normal text
                        string msg = null;
                        string Msg = null;
                        msg = receivedMessages[i + 1];
                        StringBuilder sb = new StringBuilder();
                        for (int j = 0; j < msg.Length; j += 4)
                        {
                            sb.AppendFormat("\\u{0:x4}", msg.Substring(j, 4));
                        }
                        Msg = System.Text.RegularExpressions.Regex.Unescape(sb.ToString()).Replace("\"", string.Empty);

                        //Insert received message to "TblSmsReceived" of database
                        TblSmsReceived smsReceived = new TblSmsReceived()
                        {
                            Phone = phone,
                            Date = DateTime.Now,
                            Message = Msg,
                            IsVisit = false
                        };
                        await _context.TblSmsReceiveds.AddAsync(smsReceived);
                        await _context.SaveChangesAsync();

                        //Check if received message body equals to special charachters do somethings

                        //1 => registeration
                        if (Msg.Equals("1") || Msg.Equals("۱"))
                        {
                            //Generating a hash key from sender phone number and current date and time for user registeration ID
                            string HashId = null;
                            HashId = Utils.CreateMD5(phone + DateTime.Now.Ticks);
                            while (_context.TblLinks.Any(s => s.Id == HashId))
                            {
                                HashId = Utils.CreateMD5(phone + DateTime.Now.Ticks);
                            }

                            //Create a row to "TblLink" of database for registering user
                            TblLink link = new TblLink()
                            {
                                Id = HashId,
                                Phone = phone,
                                ExpireDate = DateTime.Now.AddDays(1)
                            };
                            await _context.TblLinks.AddAsync(link);
                            await _context.SaveChangesAsync();

                            //Generate link of user registeration
                            string realLink = null;
                            string appIp = System.Configuration.ConfigurationManager.AppSettings["AppIp"];
                            realLink = "http://" + appIp + "/" + HashId;

                            //Generate shortlink from realLink(generated link of user registeration) and split JSON data by ":"
                            string[] shortedLink = null;
                            string shortlinke = null;
                            string shortLinkIp = System.Configuration.ConfigurationManager.AppSettings["ShortLinkIp"];
                            shortedLink = Shortlink("http://" + shortLinkIp + "/api/Page/" + realLink).Split(':');
                            shortlinke = (shortedLink[1] + ":" + shortedLink[2]).Replace("\"", string.Empty).Replace("}", string.Empty);

                            //Create a record in TblSent for sent later
                            string sentmsg = null;
                            sentmsg = "لینک ثبت نام:\n" + "http://" + shortlinke;
                            TblSmsSent tblSmsSent = new TblSmsSent
                            {
                                Message = sentmsg,
                                Date = DateTime.Now,
                                Phone = phone,
                                IsRead = false
                            };
                            await _context.AddAsync(tblSmsSent);
                            await _context.SaveChangesAsync();

                        }
                    }

                }

                //Delete all read messages (untouch unreads)
                serialPort.WriteLine("AT" + System.Environment.NewLine);
                Thread.Sleep(2000);
                serialPort.WriteLine("AT+CMGF=1\r" + System.Environment.NewLine);
                Thread.Sleep(2000);
                serialPort.WriteLine("AT+CMGD=1,3" + System.Environment.NewLine);
                Thread.Sleep(2000);


            }
            catch (Exception)
            {
                //LogErrors("Error On Openning Port" + Environment.NewLine);
                //ResetApp();
            }
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
            ReadSmsServiceStatusLabel.ForeColor = Color.Red;
            ReadSmsServiceButton.Enabled = true;
            StopReadServiceButton.Enabled = false;
        }

        private void StartReaderService()
        {
            ReadSmsServiceStatusLabel.Text = "در حال اجرا";
            ReadSmsServiceStatusLabel.ForeColor = Color.Green;
            ReadSmsServiceButton.Enabled = false;
            StopReadServiceButton.Enabled = true;
        }

        private static string Shortlink(string url)
        {
            var request = WebRequest.Create(url);
            string text;
            request.ContentType = "application/json; charset=utf-8";
            var response = (HttpWebResponse)request.GetResponse();

            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                text = sr.ReadToEnd();
            }
            return text;
        }
    }
}
