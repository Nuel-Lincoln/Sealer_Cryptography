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
    public partial class Base64String : UserControl
    {
        public Base64String()
        {
            InitializeComponent();
        }

        private void Base64B_Click(object sender, EventArgs e)
        {
            AESEncryption aes = new AESEncryption();
            Base64Out.Text = aes.GenerateRandomBase64Key();

        }
    }
}
