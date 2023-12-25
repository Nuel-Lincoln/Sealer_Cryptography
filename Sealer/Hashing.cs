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
    public partial class Hashing : UserControl
    {
        public Hashing()
        {
            InitializeComponent();
        }

        private void EncryptOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void Decrypt_Click(object sender, EventArgs e)
        {

        }

        private void HashB_Click(object sender, EventArgs e)
        {
            AESEncryption aes = new AESEncryption();

            string Value = HashIn.Text;

            if (Value.Length < 0)
            {
                HashOut.Text = "Invalid string to encrypt";
                HashOut.ForeColor = Color.Red;
            }
            else
            {
                HashOut.Text = aes.HashString(Value);
                HashOut.ForeColor = Color.Green;
            }

        }

        private void Compare_Click(object sender, EventArgs e)
        {

        }
    }
}
