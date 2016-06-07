using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.tableLayoutLogin.Dock = DockStyle.Fill;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsUserExist(textID.Text, textPassword.Text))
                {
                    Login formkapa = new Login();
                    formkapa.Close();
                    KutuphaneGiris form = new KutuphaneGiris();
                    form.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show("Hatalı Kullanıcı Adı Veya Şifre Lütfen Tekrar Deneyin!");
            }
            catch { 
            
            
            
            }
        }

        private bool IsUserExist(string userName, string password)
        {

            kutuphaneDataContext context = new kutuphaneDataContext();
            var q = from p in context.Users
                    where p.Username == userName
                    && p.Password == password
                    select p;

            if (q.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
