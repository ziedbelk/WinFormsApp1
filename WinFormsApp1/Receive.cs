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
using System.Reflection.Emit;

namespace WinFormsApp1
{
    public partial class Receive : UserControl
    {
        public Receive()
        {
            InitializeComponent();
            Welcometoyourwallet wtw = new Welcometoyourwallet();
            string monadress = wtw.MyreceiveAdress;
            receiveadresslab.Text = monadress;
            qrBox.Hide();
        }
        #region qr code generation
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string s = receiveadresslab.Text;
            var writer = new QRCodeWriter();
            var result = writer.encode(s, BarcodeFormat.QR_CODE, 250, 250);
            var matrix = result;
            Bitmap resultat = new Bitmap(250, 250);
            for (int x = 0; x < matrix.Width; x++)
            {
                for (int i = 0; i < matrix.Height; i++)
                {
                    Color pixel = matrix[x, i] ? Color.Black : Color.White;
                    resultat.SetPixel(x, i, pixel);
                }
            }
            qrBox.Image = resultat;
            qrBox.Show();
            pictureBox1.Hide(); 

        }
        #endregion


        private void label2_Click(object sender, EventArgs e)
        {

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(receiveadresslab.Text);
        }
    }
}
