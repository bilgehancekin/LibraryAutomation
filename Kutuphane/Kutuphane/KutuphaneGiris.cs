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
    public partial class KutuphaneGiris : Form
    {
        public KutuphaneGiris()
        {
            InitializeComponent();
            buttonBooks.BackgroundImageLayout = ImageLayout.Stretch;
            buttonMembers.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBorrows.BackgroundImageLayout = ImageLayout.Stretch;
            buttonWriters.BackgroundImageLayout = ImageLayout.Stretch;
            buttonBookTypes.BackgroundImageLayout = ImageLayout.Stretch;
            buttonSearch.BackgroundImageLayout = ImageLayout.Stretch;
            this.tableLayoutPanel1.Dock = DockStyle.Fill;
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            KitapIslemleri form = new KitapIslemleri();
            form.Show();
        }

        private void buttonMembers_Click(object sender, EventArgs e)
        {
            UyeIslemleri form = new UyeIslemleri();
            form.Show();
        }

        private void KutuphaneGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBorrows_Click(object sender, EventArgs e)
        {
            EmanetIslemleri form = new EmanetIslemleri();
            form.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AramaIslemleri form = new AramaIslemleri();
            form.Show();
        }

        private void buttonWriters_Click(object sender, EventArgs e)
        {
            YazarIslemleri form = new YazarIslemleri();
            form.Show();
        }

        private void buttonBookTypes_Click(object sender, EventArgs e)
        {
            KitapTuruIslemleri form = new KitapTuruIslemleri();
            form.Show();
        }
    
    }
}
