using NBitcoin;
using QBitNinja.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.QrCode;

namespace WinFormsApp1
{
    public partial class Wallettracker : UserControl
    {
        public Wallettracker()
        {
            InitializeComponent();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            totalreceivelab.Hide();
            balancelab.Hide();
            transactionlab.Hide();
            totalsendlab.Hide();
            pictureBox1.Hide();
            balancelab.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {


            Bitmap resultat = new Bitmap(250, 250);

            string searchedwallet = textBox1.Text;
            //use searchedwallet(searched wallet adress) to search for btc blockchain wallet   

            var client = new QBitNinjaClient(Network.Main);
            var address = new BitcoinPubKeyAddress(searchedwallet, Network.Main);

            var balancemodel = client.GetBalance(address).Result;
            decimal adressbalance = 0;
            decimal adressout = 0;
            int totaltransactions = balancemodel.Operations.Count;
            transactionlab.Text= totaltransactions.ToString();
            if (balancemodel.Operations.Count == 0)
            {
                adressbalance = 0;
            }
            else
            {
                var unspentcoins = new List<Coin>();
                var sendedcoin = new List<Coin>();
                foreach (var operation in balancemodel.Operations)
                {
                    unspentcoins.AddRange(operation.ReceivedCoins.Select(Coin => Coin as Coin));
                    sendedcoin.AddRange(operation.SpentCoins.Select(Coin => Coin as Coin));
                    adressbalance = unspentcoins.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                    adressout = sendedcoin.Sum(x => x.Amount.ToDecimal(MoneyUnit.BTC));
                }

                totalsendlab.Text = adressout.ToString()+" BTC";
                totalreceivelab.Text = adressbalance.ToString()+" BTC";
                balancelab.Text = (adressbalance - adressout).ToString()+" BTC";

                var writer = new QRCodeWriter();
                var result = writer.encode(searchedwallet, BarcodeFormat.QR_CODE, 210, 210);
                var matrix = result;
                for (int x = 0; x < matrix.Width; x++)
                {
                    for (int i = 0; i < matrix.Height; i++)
                    {
                        Color pixel = matrix[x, i] ? Color.Black : Color.White;
                        resultat.SetPixel(x, i, pixel);
                    }
                }
            }

           
            pictureBox1.Image = resultat;
            label1.Show();
            label2.Show();
            label3.Show();
            label5.Show();
            totalreceivelab.Show();
            balancelab.Show();
            transactionlab.Show();
            totalsendlab.Show();
            pictureBox1.Show();
            balancelab.Show();
        }
    }
}
