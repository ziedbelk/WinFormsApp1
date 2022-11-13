namespace WinFormsApp1
{
    partial class Receive
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
            this.receiveadresslab = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adressLabel = new System.Windows.Forms.Label();
            this.qrBox = new System.Windows.Forms.PictureBox();
            this.copyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).BeginInit();
            this.SuspendLayout();
            // 
            // receiveadresslab
            // 
            this.receiveadresslab.AutoSize = true;
            this.receiveadresslab.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.receiveadresslab.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.receiveadresslab.Location = new System.Drawing.Point(407, 149);
            this.receiveadresslab.Name = "receiveadresslab";
            this.receiveadresslab.Size = new System.Drawing.Size(66, 21);
            this.receiveadresslab.TabIndex = 32;
            this.receiveadresslab.Text = "Adress :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::WinFormsApp1.Properties.Resources.generatepng;
            this.pictureBox1.Location = new System.Drawing.Point(503, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 150);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.adressLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adressLabel.Location = new System.Drawing.Point(279, 149);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(105, 21);
            this.adressLabel.TabIndex = 34;
            this.adressLabel.Text = "Your adress :";
            this.adressLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // qrBox
            // 
            this.qrBox.Location = new System.Drawing.Point(460, 190);
            this.qrBox.Name = "qrBox";
            this.qrBox.Size = new System.Drawing.Size(250, 250);
            this.qrBox.TabIndex = 36;
            this.qrBox.TabStop = false;
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.copyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copyButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copyButton.Image = global::WinFormsApp1.Properties.Resources.copypng;
            this.copyButton.Location = new System.Drawing.Point(538, 61);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(64, 63);
            this.copyButton.TabIndex = 37;
            this.copyButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Receive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.qrBox);
            this.Controls.Add(this.adressLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.receiveadresslab);
            this.Name = "Receive";
            this.Size = new System.Drawing.Size(1242, 525);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label receiveadresslab;
        private PictureBox pictureBox1;
        private Label adressLabel;
        private PictureBox qrBox;
        private Button copyButton;
    }
}
