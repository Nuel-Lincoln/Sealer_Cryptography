namespace Sealer
{
    partial class Hashing
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
            Compare = new Button();
            HashB = new Button();
            HashV2 = new TextBox();
            HashV1 = new TextBox();
            Decrypt = new Label();
            HashOut = new TextBox();
            HashIn = new TextBox();
            label1 = new Label();
            label2 = new Label();
            HashResult = new TextBox();
            SuspendLayout();
            // 
            // Compare
            // 
            Compare.Cursor = Cursors.Hand;
            Compare.ForeColor = SystemColors.ActiveCaptionText;
            Compare.Location = new Point(588, 330);
            Compare.Name = "Compare";
            Compare.Size = new Size(112, 34);
            Compare.TabIndex = 15;
            Compare.Text = "Compare";
            Compare.UseVisualStyleBackColor = true;
            Compare.Click += Compare_Click;
            // 
            // HashB
            // 
            HashB.Cursor = Cursors.Hand;
            HashB.ForeColor = SystemColors.ActiveCaptionText;
            HashB.Location = new Point(631, 156);
            HashB.Name = "HashB";
            HashB.Size = new Size(112, 34);
            HashB.TabIndex = 14;
            HashB.Text = "Hash";
            HashB.UseVisualStyleBackColor = true;
            HashB.Click += HashB_Click;
            // 
            // HashV2
            // 
            HashV2.BackColor = SystemColors.ScrollBar;
            HashV2.Location = new Point(368, 253);
            HashV2.Multiline = true;
            HashV2.Name = "HashV2";
            HashV2.Size = new Size(155, 52);
            HashV2.TabIndex = 13;
            // 
            // HashV1
            // 
            HashV1.BackColor = SystemColors.Info;
            HashV1.Location = new Point(153, 250);
            HashV1.Multiline = true;
            HashV1.Name = "HashV1";
            HashV1.Size = new Size(149, 55);
            HashV1.TabIndex = 12;
            // 
            // Decrypt
            // 
            Decrypt.AutoSize = true;
            Decrypt.ForeColor = SystemColors.ActiveCaptionText;
            Decrypt.Location = new Point(12, 210);
            Decrypt.Name = "Decrypt";
            Decrypt.Size = new Size(109, 25);
            Decrypt.TabIndex = 11;
            Decrypt.Text = "Decrypt Text";
            Decrypt.Click += Decrypt_Click;
            // 
            // HashOut
            // 
            HashOut.BackColor = SystemColors.ScrollBar;
            HashOut.HideSelection = false;
            HashOut.Location = new Point(153, 86);
            HashOut.Multiline = true;
            HashOut.Name = "HashOut";
            HashOut.Size = new Size(590, 64);
            HashOut.TabIndex = 10;
            HashOut.TextChanged += EncryptOut_TextChanged;
            // 
            // HashIn
            // 
            HashIn.BackColor = SystemColors.Info;
            HashIn.Location = new Point(153, 19);
            HashIn.Multiline = true;
            HashIn.Name = "HashIn";
            HashIn.Size = new Size(590, 61);
            HashIn.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(52, 25);
            label1.TabIndex = 8;
            label1.Text = "Hash";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(327, 268);
            label2.Name = "label2";
            label2.Size = new Size(24, 25);
            label2.TabIndex = 16;
            label2.Text = "=";
            // 
            // HashResult
            // 
            HashResult.BackColor = SystemColors.MenuBar;
            HashResult.Location = new Point(588, 253);
            HashResult.Multiline = true;
            HashResult.Name = "HashResult";
            HashResult.Size = new Size(155, 52);
            HashResult.TabIndex = 17;
            // 
            // Hashing
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(HashResult);
            Controls.Add(label2);
            Controls.Add(Compare);
            Controls.Add(HashB);
            Controls.Add(HashV2);
            Controls.Add(HashV1);
            Controls.Add(Decrypt);
            Controls.Add(HashOut);
            Controls.Add(HashIn);
            Controls.Add(label1);
            Name = "Hashing";
            Size = new Size(870, 578);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Compare;
        private Button HashB;
        private TextBox HashV2;
        private TextBox HashV1;
        private Label Decrypt;
        private TextBox HashOut;
        private TextBox HashIn;
        private Label label1;
        private Label label2;
        private TextBox HashResult;
    }
}
