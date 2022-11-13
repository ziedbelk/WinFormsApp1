using NBitcoin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing.QrCode;
using ZXing;
using System.Security.Cryptography.X509Certificates;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp1
{
    public partial class Welcometoyourwallet : UserControl
    {
        public string MyreceiveAdress;
         public Key MyWalletPrivateKey = new Key() ;
        public Key MyWalletPublicKey = new Key();

        public Welcometoyourwallet()
        {
            InitializeComponent();
            // blockchain private key creation

            var privatekey = new Key();
            MyWalletPrivateKey = privatekey.GetWif(Network.Main);
            privatekeylab.Text = btcprivatekey.ToString();

            // generate public key from wallet private key

            MyWalletPublicKey = privatekey.PubKey.ToString();

            // blockchain receive adress creation

            MyWalletPublicKey = privatekey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            adresslab.Text = MyWalletPublicKey.ToString();
            MyreceiveAdress = MyWalletPublicKey.ToString();

            // wallet mnemonic phrase creation
            var mnemo = new Mnemonic(Wordlist.English, WordCount.Twelve);
            menomiclab.Text = mnemo.ToString();

            // generate adresse from our mnemo phrase

            var hdroot = mnemo.DeriveExtKey();
            var pkey = hdroot.Derive(new KeyPath("m/84'/0'/0'/0'/0'"));
            var adress = pkey.PrivateKey.PubKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main).ToString();
            seedlab.Text = adress;
            string s = adresslab.Text;

            // wallet qrcode creation 
            var writer = new QRCodeWriter();
            var result = writer.encode(s, BarcodeFormat.QR_CODE, 310, 310);
            var matrix = result;
            Bitmap resultat = new Bitmap(310, 310);
            for (int x = 0; x < matrix.Width; x++)
            {
                for (int i = 0; i < matrix.Height; i++)
                {
                    Color pixel = matrix[x, i] ? Color.Black : Color.White;
                    resultat.SetPixel(x, i, pixel);
                }
            }
            qrCodePicBox.Image = resultat;

            qrCodePicBox.Show();
            DateTime now = DateTime.Now;
            datelab.Text = now.ToString();
         
        }
       
    }
}
