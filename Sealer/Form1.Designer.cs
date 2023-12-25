namespace Sealer
{
    partial class Sealer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Hashing = new Button();
            ED = new Button();
            Base64String = new Button();
            hashing1 = new Hashing();
            encryptDecrypt1 = new EncryptDecrypt();
            base64String1 = new Base64String();
            SuspendLayout();
            // 
            // Hashing
            // 
            Hashing.Cursor = Cursors.Hand;
            Hashing.ForeColor = SystemColors.ActiveCaptionText;
            Hashing.Location = new Point(455, -1);
            Hashing.Name = "Hashing";
            Hashing.Size = new Size(112, 34);
            Hashing.TabIndex = 8;
            Hashing.Text = "Hashing";
            Hashing.UseVisualStyleBackColor = true;
            Hashing.Click += Hashing_Click;
            // 
            // ED
            // 
            ED.Cursor = Cursors.Hand;
            ED.ForeColor = SystemColors.ActiveCaptionText;
            ED.Location = new Point(143, -1);
            ED.Name = "ED";
            ED.Size = new Size(175, 34);
            ED.TabIndex = 9;
            ED.Text = "Encrypt/Decrypt";
            ED.UseVisualStyleBackColor = true;
            ED.Click += button4_Click;
            // 
            // Base64String
            // 
            Base64String.Cursor = Cursors.Hand;
            Base64String.ForeColor = SystemColors.ActiveCaptionText;
            Base64String.Location = new Point(712, -1);
            Base64String.Name = "Base64String";
            Base64String.Size = new Size(149, 34);
            Base64String.TabIndex = 10;
            Base64String.Text = "Base64String";
            Base64String.UseVisualStyleBackColor = true;
            Base64String.Click += Base64String_Click;
            // 
            // hashing1
            // 
            hashing1.Location = new Point(71, 94);
            hashing1.Name = "hashing1";
            hashing1.Size = new Size(844, 480);
            hashing1.TabIndex = 11;
            // 
            // encryptDecrypt1
            // 
            encryptDecrypt1.BackColor = SystemColors.ControlLightLight;
            encryptDecrypt1.Location = new Point(40, 55);
            encryptDecrypt1.Name = "encryptDecrypt1";
            encryptDecrypt1.Size = new Size(980, 665);
            encryptDecrypt1.TabIndex = 12;
            // 
            // base64String1
            // 
            base64String1.Location = new Point(40, 55);
            base64String1.Name = "base64String1";
            base64String1.Size = new Size(980, 639);
            base64String1.TabIndex = 13;
            // 
            // Sealer
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 721);
            Controls.Add(base64String1);
            Controls.Add(encryptDecrypt1);
            Controls.Add(hashing1);
            Controls.Add(Base64String);
            Controls.Add(ED);
            Controls.Add(Hashing);
            Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.AppWorkspace;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Sealer";
            RightToLeft = RightToLeft.No;
            Text = "Sealer";
            ResumeLayout(false);
        }

        #endregion
        private Button Hashing;
        private Button ED;
        private Button Base64String;
        private Hashing hashing1;
        private EncryptDecrypt encryptDecrypt1;
        private Base64String base64String1;
    }
}
