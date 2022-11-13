using AForge.Video;
using AForge.Video.DirectShow;
using IronBarCode;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;
using NBitcoin;
using QBitNinja.Client;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class SendBTC : UserControl
    {
        public SendBTC()
        {

            InitializeComponent();
            Welcometoyourwallet wtw = new Welcometoyourwallet();
            _prvKey = wtw.MyWalletPrivateKey;
            _PbKey = wtw.MyWalletPublicKey;
            ScanWindow.Hide();

            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbodevice.Items.Add(filterInfo.Name);
                cbodevice.SelectedIndex = 0;
            }

        }
        private Key _prvKey = new Key();
        private Key _PbKey = new Key();
        private Timer timer1;
        private string _scannedAdress = null;
        private int x;
        public void InitTimer()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 10;
            timer1.Start();


        }


        // scan the qrcode for every 0.01 second
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (ScanWindow.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Bitmap BitmapImage = new Bitmap(ScanWindow.Image);
                Result result = barcodeReader.Decode(BitmapImage);
                if (result != null)
                {
                    _scannedAdress = result.ToString();
                    recAdressBox.Text = _scannedAdress;
                    if (capturedevice.IsRunning)
                    {

                        capturedevice.Stop();
                        timer1.Stop();


                    }

                }

            }



        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice capturedevice;

        #region creation of btc blockchain transaction 
        private void Sendbox_Click(object sender, EventArgs e)
        {
            var amount = string.Format("{0:#.00}", Convert.ToDecimal(amountTextBox.Text) / 100);
            var fee = string.Format("{0:#.00}", Convert.ToDecimal(feeTextBox.Text) / 100);
            var minerFee = new Money(fee, MoneyUnit.BTC);


            bool existedAdress = SearchForAdress(_scannedAdress);
            if (existedAdress == true)
            {
                TransactionBuilder builder = Network.Main.CreateTransactionBuilder();
                try
                {
                    var destination = BitcoinAddress.Create(_scannedAdress).ScriptPubKey;


                    Coin[] coins = transaction.Outputs.AsCoins().ToArray();

                    builder = new TransactionBuilder();
                    Transaction tx = builder
                        .AddCoins(coins[0])
                        .AddKeys(_prvKey)
                        .Send(destination, Money.Coins(amount))
                        .SetChange(_PbKey)
                        .SendFees(minerFee)
                        .BuildTransaction(sign: true);

                    if (builder.Verify(tx))
                    {
                        string message = "You have sent" + amount + "to this adress :" + _scannedAdress;
                        string title = "Message";
                        MessageBox.Show(message, title);
                    }

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                string message = "This is not a blockchain adress Zied";
                string title = "Warning";
                MessageBox.Show(message, title);
            }
        }
        #endregion
        // start qrcode video recording button 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ScanWindow.Show();
            capturedevice = new VideoCaptureDevice(filterInfoCollection[cbodevice.SelectedIndex].MonikerString);

            capturedevice.NewFrame += new NewFrameEventHandler(capturedevice_NewFrame);

            capturedevice.Start();
            InitTimer();
        }

        private void capturedevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ScanWindow.Image = (Bitmap)eventArgs.Frame.Clone();

        }

        // stop qrcode video recording button 

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            capturedevice.Stop();
            ScanWindow.Hide();


        }
        #region search for the destination adresse if it is exist 

        private bool SearchForAdress(string scAdress)
        {
            bool BlockchainAdressExist = false;
            var client = new QBitNinjaClient(Network.Main);
            var address = new BitcoinPubKeyAddress(scAdress, Network.Main);
            if (address != null)
            {
                BlockchainAdressExist = true;

            }
            return BlockchainAdressExist;
        }
        #endregion
    }
}
