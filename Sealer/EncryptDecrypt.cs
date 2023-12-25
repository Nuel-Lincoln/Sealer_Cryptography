using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sealer
{
    public partial class EncryptDecrypt : UserControl
    {
        public EncryptDecrypt()
        {
            InitializeComponent();
        }

        private void EncryptB_Click(object sender, EventArgs e)
        {
            AESEncryption aes = new AESEncryption();

            string Value = EncryptIn.Text;

            if (Value.Length <= 0)
            {
                EncryptOut.Text = "Invalid string to encrypt";
                EncryptOut.ForeColor = Color.Red;
            }
            else
            {
                EncryptOut.Text = aes.Encrypt(Value);
                EncryptOut.ForeColor = Color.Green;
            }

        }


        private void DecryptB_Click(object sender, EventArgs e)
        {
            AESEncryption aes = new AESEncryption();

            string Value = DecryptIn.Text;

            if (Value.Length <= 0)
            {
                DecryptOut.Text = "Invalid string to encrypt";
                DecryptOut.ForeColor = Color.Red;
            }
            else
            {
                DecryptOut.Text = aes.Decrypt(Value);
                DecryptOut.ForeColor = Color.Green;
            }

        }

        private void DecryptB_Click_1(object sender, EventArgs e)
        {
            AESEncryption aes = new AESEncryption();

            string Value = DecryptIn.Text;

            if (Value.Length <= 0)
            {
                DecryptOut.Text = "Invalid string to encrypt";
                DecryptOut.ForeColor = Color.Red;
            }
            else
            {
                DecryptOut.Text = aes.Decrypt(Value);
                DecryptOut.ForeColor = Color.Green;
            }
        }
    }
}
