namespace WinFormsApp1
{
    partial class SendBTC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SendBTC));
            this.recAdressBox = new System.Windows.Forms.TextBox();
            this.feeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Sendbox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ScanWindow = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sendbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // recAdressBox
            // 
            this.recAdressBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.recAdressBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.recAdressBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.recAdressBox.Location = new System.Drawing.Point(219, 99);
            this.recAdressBox.Name = "recAdressBox";
            this.recAdressBox.Size = new System.Drawing.Size(633, 35);
            this.recAdressBox.TabIndex = 24;
            this.recAdressBox.Text = "Send to ...";
            this.recAdressBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // feeTextBox
            // 
            this.feeTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.feeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.feeTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.feeTextBox.Location = new System.Drawing.Point(219, 216);
            this.feeTextBox.Name = "feeTextBox";
            this.feeTextBox.Size = new System.Drawing.Size(110, 35);
            this.feeTextBox.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(219, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Send to :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(219, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Miners fee :";
            // 
            // Sendbox
            // 
            this.Sendbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sendbox.Image = global::WinFormsApp1.Properties.Resources.send;
            this.Sendbox.Location = new System.Drawing.Point(869, 99);
            this.Sendbox.Name = "Sendbox";
            this.Sendbox.Size = new System.Drawing.Size(39, 35);
            this.Sendbox.TabIndex = 37;
            this.Sendbox.TabStop = false;
            this.Sendbox.Click += new System.EventHandler(this.Sendbox_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(483, 216);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(153, 150);
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ScanWindow
            // 
            this.ScanWindow.Location = new System.Drawing.Point(419, 157);
            this.ScanWindow.Name = "ScanWindow";
            this.ScanWindow.Size = new System.Drawing.Size(280, 280);
            this.ScanWindow.TabIndex = 40;
            this.ScanWindow.TabStop = false;
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
            this.button2.Location = new System.Drawing.Point(532, 459);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 63);
            this.button2.TabIndex = 41;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.amountTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.amountTextBox.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.amountTextBox.Location = new System.Drawing.Point(219, 27);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(633, 35);
            this.amountTextBox.TabIndex = 42;
            this.amountTextBox.Text = "Amount to send ...";
            this.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(219, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 43;
            this.label3.Text = "Set your amount :";
            // 
            // SendBTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ScanWindow);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Sendbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.feeTextBox);
            this.Controls.Add(this.recAdressBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "SendBTC";
            this.Size = new System.Drawing.Size(1242, 525);
            ((System.ComponentModel.ISupportInitialize)(this.Sendbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScanWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox recAdressBox;
        private TextBox feeTextBox;
        private Label label2;
        private Label label1;
        private PictureBox Sendbox;
        private PictureBox pictureBox2;
        private PictureBox ScanWindow;
        private Button button2;
        private TextBox amountTextBox;
        private Label label3;
    }
}
