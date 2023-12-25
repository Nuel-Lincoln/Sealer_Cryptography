namespace Sealer
{
    public partial class Sealer : Form
    {
        public Sealer()
        {
            InitializeComponent();
            base64String1.Hide();
            hashing1.Hide();
            encryptDecrypt1.BackColor = Color.AliceBlue;
            ForeColor = Color.White;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            base64String1.Hide();
            hashing1.Hide();
            encryptDecrypt1.Show();
        }

        private void Hashing_Click(object sender, EventArgs e)
        {
            encryptDecrypt1.Hide();
            base64String1.Hide();
            hashing1.Show();
        }

        private void Base64String_Click(object sender, EventArgs e)
        {
            encryptDecrypt1.Hide();
            hashing1.Hide();
            base64String1.Show();
        }
    }
}
