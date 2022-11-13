using NBitcoin;
using QBitNinja.Client.Models;
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

namespace WinFormsApp1
{
    public partial class Transactiontrack : UserControl
    {
        public Transactiontrack()
        {
            InitializeComponent();
            amountToSendLabel.Hide();
            receiveAdressLabel.Hide();
            feeLabel.Hide();
            amountLabel.Hide();
            SendedToLabel.Hide();
            MinersFeeLabel.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string trid = textBox1.Text;

            QBitNinjaClient client = new QBitNinjaClient(Network.Main);
            var transactionId = uint256.Parse(trid);
            GetTransactionResponse transactionResponse = client.GetTransaction(transactionId).Result;
            NBitcoin.Transaction transaction = transactionResponse.Transaction;

            List<ICoin> receivedCoins = transactionResponse.ReceivedCoins;
            Money spentAmount = Money.Zero;
            var spentCoins = transactionResponse.SpentCoins;
              
            foreach (var coin in receivedCoins)
            {
                Money amount = (Money)coin.Amount;

                Console.WriteLine(amount.ToDecimal(MoneyUnit.BTC));
                var paymentScript = coin.TxOut.ScriptPubKey;

                Console.WriteLine(paymentScript);  
                var address = paymentScript.GetDestinationAddress(Network.Main);
                receiveAdressLabel.Text = address.ToString();
                Console.WriteLine(address); 
                Console.WriteLine();

                foreach (var spentCoin in spentCoins)
                {
                    spentAmount = (Money)spentCoin.Amount.Add(spentAmount);
                }
                amountToSendLabel.Text = spentAmount.ToString()+" BTC";
            }

            var fee = transaction.GetFee(spentCoins.ToArray());
            feeLabel.Text = fee.ToString();
            amountToSendLabel.Show();
            receiveAdressLabel.Show();
            feeLabel.Show();
            amountLabel.Show();
            SendedToLabel.Show();
            MinersFeeLabel.Show();
        }
    }
}
