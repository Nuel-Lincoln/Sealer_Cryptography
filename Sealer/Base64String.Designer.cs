namespace Sealer
{
    partial class Base64String
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
            label1 = new Label();
            Base64Out = new TextBox();
            Base64B = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(237, 12);
            label1.Name = "label1";
            label1.Size = new Size(334, 36);
            label1.TabIndex = 0;
            label1.Text = "Generate Base 64 String";
            // 
            // Base64Out
            // 
            Base64Out.BackColor = SystemColors.ControlLight;
            Base64Out.HideSelection = false;
            Base64Out.Location = new Point(86, 86);
            Base64Out.Multiline = true;
            Base64Out.Name = "Base64Out";
            Base64Out.ReadOnly = true;
            Base64Out.Size = new Size(665, 175);
            Base64Out.TabIndex = 1;
            // 
            // Base64B
            // 
            Base64B.BackColor = SystemColors.ActiveCaptionText;
            Base64B.Font = new Font("Times New Roman", 11F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            Base64B.ForeColor = SystemColors.ButtonHighlight;
            Base64B.Location = new Point(639, 294);
            Base64B.Name = "Base64B";
            Base64B.Size = new Size(112, 34);
            Base64B.TabIndex = 2;
            Base64B.Text = "Generate";
            Base64B.UseVisualStyleBackColor = false;
            Base64B.Click += Base64B_Click;
            // 
            // Base64String
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(Base64B);
            Controls.Add(Base64Out);
            Controls.Add(label1);
            Name = "Base64String";
            Size = new Size(865, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox Base64Out;
        private Button Base64B;
    }
}
