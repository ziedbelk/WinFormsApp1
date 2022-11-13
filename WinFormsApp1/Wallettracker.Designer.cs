namespace WinFormsApp1
{
    partial class Wallettracker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wallettracker));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mnemolab = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.balancelab = new System.Windows.Forms.Label();
            this.transactionlab = new System.Windows.Forms.Label();
            this.totalreceivelab = new System.Windows.Forms.Label();
            this.totalsendlab = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBox1.Location = new System.Drawing.Point(210, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(633, 35);
            this.textBox1.TabIndex = 0;
            // 
            // mnemolab
            // 
            this.mnemolab.AutoSize = true;
            this.mnemolab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mnemolab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mnemolab.Location = new System.Drawing.Point(210, 50);
            this.mnemolab.Name = "mnemolab";
            this.mnemolab.Size = new System.Drawing.Size(119, 21);
            this.mnemolab.TabIndex = 21;
            this.mnemolab.Text = "Wallet adress :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(858, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 35);
            this.button2.TabIndex = 22;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(263, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 210);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(536, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total sends : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(536, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Total receives :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(536, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(536, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Transactions : ";
            // 
            // balancelab
            // 
            this.balancelab.AutoSize = true;
            this.balancelab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.balancelab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.balancelab.Location = new System.Drawing.Point(620, 195);
            this.balancelab.Name = "balancelab";
            this.balancelab.Size = new System.Drawing.Size(114, 21);
            this.balancelab.TabIndex = 29;
            this.balancelab.Text = "Transactions : ";
            // 
            // transactionlab
            // 
            this.transactionlab.AutoSize = true;
            this.transactionlab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.transactionlab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transactionlab.Location = new System.Drawing.Point(659, 236);
            this.transactionlab.Name = "transactionlab";
            this.transactionlab.Size = new System.Drawing.Size(114, 21);
            this.transactionlab.TabIndex = 30;
            this.transactionlab.Text = "Transactions : ";
            // 
            // totalreceivelab
            // 
            this.totalreceivelab.AutoSize = true;
            this.totalreceivelab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.totalreceivelab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalreceivelab.Location = new System.Drawing.Point(674, 281);
            this.totalreceivelab.Name = "totalreceivelab";
            this.totalreceivelab.Size = new System.Drawing.Size(114, 21);
            this.totalreceivelab.TabIndex = 31;
            this.totalreceivelab.Text = "Transactions : ";
            // 
            // totalsendlab
            // 
            this.totalsendlab.AutoSize = true;
            this.totalsendlab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.totalsendlab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalsendlab.Location = new System.Drawing.Point(649, 330);
            this.totalsendlab.Name = "totalsendlab";
            this.totalsendlab.Size = new System.Drawing.Size(114, 21);
            this.totalsendlab.TabIndex = 32;
            this.totalsendlab.Text = "Transactions : ";
            // 
            // Wallettracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.totalsendlab);
            this.Controls.Add(this.totalreceivelab);
            this.Controls.Add(this.transactionlab);
            this.Controls.Add(this.balancelab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.mnemolab);
            this.Controls.Add(this.textBox1);
            this.Name = "Wallettracker";
            this.Size = new System.Drawing.Size(1242, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label mnemolab;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label balancelab;
        private Label transactionlab;
        private Label totalreceivelab;
        private Label totalsendlab;
    }
}
