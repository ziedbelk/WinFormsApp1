namespace WinFormsApp1
{
    partial class Transactiontrack
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactiontrack));
            this.searchButton = new System.Windows.Forms.Button();
            this.mnemolab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SendedToLabel = new System.Windows.Forms.Label();
            this.receiveAdressLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountToSendLabel = new System.Windows.Forms.Label();
            this.MinersFeeLabel = new System.Windows.Forms.Label();
            this.feeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.searchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.Location = new System.Drawing.Point(860, 108);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(41, 35);
            this.searchButton.TabIndex = 25;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // mnemolab
            // 
            this.mnemolab.AutoSize = true;
            this.mnemolab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnemolab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnemolab.Location = new System.Drawing.Point(212, 73);
            this.mnemolab.Name = "mnemolab";
            this.mnemolab.Size = new System.Drawing.Size(175, 21);
            this.mnemolab.TabIndex = 24;
            this.mnemolab.Text = "Bitcoin transaction ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(212, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 35);
            this.textBox1.TabIndex = 23;
            // 
            // SendedToLabel
            // 
            this.SendedToLabel.AutoSize = true;
            this.SendedToLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SendedToLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SendedToLabel.Location = new System.Drawing.Point(212, 191);
            this.SendedToLabel.Name = "SendedToLabel";
            this.SendedToLabel.Size = new System.Drawing.Size(95, 21);
            this.SendedToLabel.TabIndex = 36;
            this.SendedToLabel.Text = "Sended to :";
            // 
            // receiveAdressLabel
            // 
            this.receiveAdressLabel.AutoSize = true;
            this.receiveAdressLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.receiveAdressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiveAdressLabel.Location = new System.Drawing.Point(409, 191);
            this.receiveAdressLabel.Name = "receiveAdressLabel";
            this.receiveAdressLabel.Size = new System.Drawing.Size(66, 21);
            this.receiveAdressLabel.TabIndex = 35;
            this.receiveAdressLabel.Text = "Adress :";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountLabel.Location = new System.Drawing.Point(212, 261);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(80, 21);
            this.amountLabel.TabIndex = 38;
            this.amountLabel.Text = "Amount :";
            // 
            // amountToSendLabel
            // 
            this.amountToSendLabel.AutoSize = true;
            this.amountToSendLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.amountToSendLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.amountToSendLabel.Location = new System.Drawing.Point(409, 261);
            this.amountToSendLabel.Name = "amountToSendLabel";
            this.amountToSendLabel.Size = new System.Drawing.Size(66, 21);
            this.amountToSendLabel.TabIndex = 37;
            this.amountToSendLabel.Text = "Adress :";
            // 
            // MinersFeeLabel
            // 
            this.MinersFeeLabel.AutoSize = true;
            this.MinersFeeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MinersFeeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinersFeeLabel.Location = new System.Drawing.Point(212, 323);
            this.MinersFeeLabel.Name = "MinersFeeLabel";
            this.MinersFeeLabel.Size = new System.Drawing.Size(105, 21);
            this.MinersFeeLabel.TabIndex = 40;
            this.MinersFeeLabel.Text = "Miners fees :";
            // 
            // feeLabel
            // 
            this.feeLabel.AutoSize = true;
            this.feeLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.feeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.feeLabel.Location = new System.Drawing.Point(409, 323);
            this.feeLabel.Name = "feeLabel";
            this.feeLabel.Size = new System.Drawing.Size(66, 21);
            this.feeLabel.TabIndex = 39;
            this.feeLabel.Text = "Adress :";
            // 
            // Transactiontrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.MinersFeeLabel);
            this.Controls.Add(this.feeLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountToSendLabel);
            this.Controls.Add(this.SendedToLabel);
            this.Controls.Add(this.receiveAdressLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.mnemolab);
            this.Controls.Add(this.textBox1);
            this.Name = "Transactiontrack";
            this.Size = new System.Drawing.Size(1242, 525);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button searchButton;
        private Label mnemolab;
        private TextBox textBox1;
        private Label SendedToLabel;
        private Label receiveAdressLabel;
        private Label amountLabel;
        private Label amountToSendLabel;
        private Label MinersFeeLabel;
        private Label feeLabel;
    }
}
