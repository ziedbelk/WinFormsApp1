namespace WinFormsApp1
{
    partial class Homepage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homepage));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.createWalletButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcprice = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ReceiveButton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.HistoryButton = new System.Windows.Forms.Button();
            this.ToolsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.walletTrack = new System.Windows.Forms.Button();
            this.transTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(444, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Create your wallet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(207, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 65);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome to your account !";
            // 
            // createWalletButton
            // 
            this.createWalletButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.createWalletButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createWalletButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.createWalletButton.FlatAppearance.BorderSize = 0;
            this.createWalletButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createWalletButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createWalletButton.Image = ((System.Drawing.Image)(resources.GetObject("createWalletButton.Image")));
            this.createWalletButton.Location = new System.Drawing.Point(416, 345);
            this.createWalletButton.Name = "createWalletButton";
            this.createWalletButton.Size = new System.Drawing.Size(207, 130);
            this.createWalletButton.TabIndex = 12;
            this.createWalletButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.createWalletButton.UseVisualStyleBackColor = false;
            this.createWalletButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(1401, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 63);
            this.button1.TabIndex = 13;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.GGGGGGGGGGGGGGG;
            this.pictureBox1.Location = new System.Drawing.Point(2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 180);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1016, 619);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Current Bitcoin price";
            // 
            // btcprice
            // 
            this.btcprice.AutoSize = true;
            this.btcprice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btcprice.Location = new System.Drawing.Point(1203, 619);
            this.btcprice.Name = "btcprice";
            this.btcprice.Size = new System.Drawing.Size(167, 21);
            this.btcprice.TabIndex = 16;
            this.btcprice.Text = "Current Bitcoin price";
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.createWalletButton);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Location = new System.Drawing.Point(223, 88);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1242, 525);
            this.MainPanel.TabIndex = 17;
            // 
            // ReceiveButton
            // 
            this.ReceiveButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ReceiveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ReceiveButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ReceiveButton.FlatAppearance.BorderSize = 0;
            this.ReceiveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReceiveButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReceiveButton.Location = new System.Drawing.Point(271, 12);
            this.ReceiveButton.Name = "ReceiveButton";
            this.ReceiveButton.Size = new System.Drawing.Size(240, 50);
            this.ReceiveButton.TabIndex = 18;
            this.ReceiveButton.Text = "Receive";
            this.ReceiveButton.UseVisualStyleBackColor = false;
            this.ReceiveButton.Click += new System.EventHandler(this.receivebutton_Click);
            // 
            // SendButton
            // 
            this.SendButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.SendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SendButton.FlatAppearance.BorderSize = 0;
            this.SendButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendButton.Location = new System.Drawing.Point(549, 12);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(240, 50);
            this.SendButton.TabIndex = 19;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = false;
            this.SendButton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // HistoryButton
            // 
            this.HistoryButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.HistoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HistoryButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.HistoryButton.FlatAppearance.BorderSize = 0;
            this.HistoryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HistoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HistoryButton.Location = new System.Drawing.Point(824, 12);
            this.HistoryButton.Name = "HistoryButton";
            this.HistoryButton.Size = new System.Drawing.Size(240, 50);
            this.HistoryButton.TabIndex = 20;
            this.HistoryButton.Text = "History";
            this.HistoryButton.UseVisualStyleBackColor = false;
            // 
            // ToolsButton
            // 
            this.ToolsButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.ToolsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ToolsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ToolsButton.FlatAppearance.BorderSize = 0;
            this.ToolsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToolsButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ToolsButton.Location = new System.Drawing.Point(1105, 12);
            this.ToolsButton.Name = "ToolsButton";
            this.ToolsButton.Size = new System.Drawing.Size(240, 50);
            this.ToolsButton.TabIndex = 21;
            this.ToolsButton.Text = "Tools";
            this.ToolsButton.UseVisualStyleBackColor = false;
            this.ToolsButton.Click += new System.EventHandler(this.toolsbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(104, 619);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Balance :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(204, 619);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 21);
            this.label5.TabIndex = 23;
            this.label5.Text = "0.00000000 BTC";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Desktop;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(711, 596);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(64, 63);
            this.button3.TabIndex = 13;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // walletTrack
            // 
            this.walletTrack.BackColor = System.Drawing.SystemColors.Desktop;
            this.walletTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.walletTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.walletTrack.FlatAppearance.BorderSize = 0;
            this.walletTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.walletTrack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.walletTrack.ForeColor = System.Drawing.Color.Transparent;
            this.walletTrack.Image = global::WinFormsApp1.Properties.Resources.searchhh;
            this.walletTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.walletTrack.Location = new System.Drawing.Point(15, 233);
            this.walletTrack.Name = "walletTrack";
            this.walletTrack.Size = new System.Drawing.Size(204, 50);
            this.walletTrack.TabIndex = 22;
            this.walletTrack.Text = "Search for a wallet";
            this.walletTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.walletTrack.UseVisualStyleBackColor = false;
            this.walletTrack.Click += new System.EventHandler(this.wallettrack_Click);
            // 
            // transTrack
            // 
            this.transTrack.BackColor = System.Drawing.SystemColors.Desktop;
            this.transTrack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.transTrack.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.transTrack.FlatAppearance.BorderSize = 0;
            this.transTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transTrack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transTrack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transTrack.Image = global::WinFormsApp1.Properties.Resources.searchhh;
            this.transTrack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.transTrack.Location = new System.Drawing.Point(15, 308);
            this.transTrack.Name = "transTrack";
            this.transTrack.Size = new System.Drawing.Size(204, 50);
            this.transTrack.TabIndex = 23;
            this.transTrack.Text = "Track a transaction";
            this.transTrack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transTrack.UseVisualStyleBackColor = false;
            this.transTrack.Click += new System.EventHandler(this.transtracker_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1467, 688);
            this.Controls.Add(this.transTrack);
            this.Controls.Add(this.walletTrack);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ToolsButton);
            this.Controls.Add(this.HistoryButton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.ReceiveButton);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.btcprice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Homepage";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private Label label1;
        private Button createWalletButton;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label3;
        private Label btcprice;
        private Panel MainPanel;
        private Button ReceiveButton;
        private Button SendButton;
        private Button HistoryButton;
        private Button ToolsButton;
        private Label label4;
        private Label label5;
        private Button button3;
        private Button walletTrack;
        private Button transTrack;
    }
}