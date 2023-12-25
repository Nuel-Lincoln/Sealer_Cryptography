namespace Sealer
{
    partial class EncryptDecrypt
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
            DecryptB = new Button();
            EncryptB = new Button();
            DecryptOut = new TextBox();
            DecryptIn = new TextBox();
            Decrypt = new Label();
            EncryptOut = new TextBox();
            EncryptIn = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // DecryptB
            // 
            DecryptB.Cursor = Cursors.Hand;
            DecryptB.ForeColor = SystemColors.ActiveCaptionText;
            DecryptB.Location = new Point(761, 617);
            DecryptB.Name = "DecryptB";
            DecryptB.Size = new Size(112, 34);
            DecryptB.TabIndex = 15;
            DecryptB.Text = "Decrypt";
            DecryptB.UseVisualStyleBackColor = true;
            DecryptB.Click += DecryptB_Click_1;
            // 
            // EncryptB
            // 
            EncryptB.Cursor = Cursors.Hand;
            EncryptB.ForeColor = SystemColors.ActiveCaptionText;
            EncryptB.Location = new Point(761, 260);
            EncryptB.Name = "EncryptB";
            EncryptB.Size = new Size(112, 34);
            EncryptB.TabIndex = 14;
            EncryptB.Text = "Encrypt";
            EncryptB.UseVisualStyleBackColor = true;
            EncryptB.Click += EncryptB_Click;
            // 
            // DecryptOut
            // 
            DecryptOut.BackColor = SystemColors.ScrollBar;
            DecryptOut.HideSelection = false;
            DecryptOut.Location = new Point(155, 495);
            DecryptOut.Multiline = true;
            DecryptOut.Name = "DecryptOut";
            DecryptOut.Size = new Size(718, 99);
            DecryptOut.TabIndex = 13;
            // 
            // DecryptIn
            // 
            DecryptIn.BackColor = SystemColors.Info;
            DecryptIn.Location = new Point(155, 350);
            DecryptIn.Multiline = true;
            DecryptIn.Name = "DecryptIn";
            DecryptIn.Size = new Size(718, 110);
            DecryptIn.TabIndex = 12;
            // 
            // Decrypt
            // 
            Decrypt.AutoSize = true;
            Decrypt.ForeColor = SystemColors.ActiveCaptionText;
            Decrypt.Location = new Point(26, 366);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(109, 25);
            Decrypt.TabIndex = 11;
            Decrypt.Text = "Decrypt Text";
            // 
            // EncryptOut
            // 
            EncryptOut.BackColor = SystemColors.ScrollBar;
            EncryptOut.HideSelection = false;
            EncryptOut.Location = new Point(155, 146);
            EncryptOut.Multiline = true;
            EncryptOut.Name = "EncryptOut";
            EncryptOut.Size = new Size(718, 108);
            EncryptOut.TabIndex = 10;
            // 
            // EncryptIn
            // 
            EncryptIn.BackColor = SystemColors.Info;
            EncryptIn.Location = new Point(155, 20);
            EncryptIn.Multiline = true;
            EncryptIn.Name = "EncryptIn";
            EncryptIn.Size = new Size(718, 120);
            EncryptIn.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(106, 25);
            label1.TabIndex = 8;
            label1.Text = "Encrypt Text";
            // 
            // EncryptDecrypt
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(DecryptB);
            Controls.Add(EncryptB);
            Controls.Add(DecryptOut);
            Controls.Add(DecryptIn);
            Controls.Add(Decrypt);
            Controls.Add(EncryptOut);
            Controls.Add(EncryptIn);
            Controls.Add(label1);
            Name = "EncryptDecrypt";
            Size = new Size(888, 660);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button DecryptB;
        private Button EncryptB;
        private TextBox DecryptOut;
        private TextBox DecryptIn;
        private Label Decrypt;
        private TextBox EncryptOut;
        private TextBox EncryptIn;
        private Label label1;
    }
}
