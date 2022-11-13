using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
             var uri = String.Format("https://blockchain.info/tobtc?currency=USD&value={0}", 1);

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            var data = client.DownloadString(uri);
            var result = 1 / Convert.ToDouble(data);
            btcprice.Text = result.ToString() + " $ ";
            //var result = 1 / Convert.ToDouble(data.Replace('.', ','));
            label4.Hide();
            label5.Hide();
            ReceiveButton.Hide();
            SendButton.Hide();
            HistoryButton.Hide();   
            ToolsButton.Hide();
            button3.Hide();
            walletTrack.Hide();
            transTrack.Hide();
            timer1 = new Timer();

            InitTimer();


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new Welcometoyourwallet());
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Hide();
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new Welcome());
            label4.Show();
            label5.Show();
            ReceiveButton.Show();
            SendButton.Show();
            HistoryButton.Show();
            ToolsButton.Show();


        }

        private void toolsbutton_Click(object sender, EventArgs e)
        {
            walletTrack.Show();
            transTrack.Show();
        }

        private void wallettrack_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new Wallettracker());
        }

        private void receivebutton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new Receive());
        }

        private void transtracker_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new Transactiontrack());
        }

        private void sendbutton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();

            MainPanel.Controls.Add(new SendBTC());
        }
        private bool starttime;
        private Timer timer1;
        private int x;
        public void InitTimer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
            var uri = String.Format("https://blockchain.info/tobtc?currency=USD&value={0}", 1);

            WebClient client = new WebClient();
            client.UseDefaultCredentials = true;
            var data = client.DownloadString(uri);
            string x = data.ToString();
            var result = 1 / Convert.ToDouble(data);
            string oldstring = btcprice.Text.Substring(0,btcprice.Text.Length - 2);
            string btcnewprice=result.ToString();
            

            double oldnumber = Convert.ToDouble(oldstring);
            double newnumber = Convert.ToDouble(btcnewprice);
            if (oldnumber > newnumber)
            {
                btcprice.ForeColor = Color.Red;
            }
            if (oldnumber < newnumber)
            {
                btcprice.ForeColor = Color.Green;
            }
            if (oldnumber == newnumber)
            {
                btcprice.ForeColor = Color.White;
            }
            btcprice.Text = result.ToString() + " $ ";





        }
    }
}
