using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseeCheckers_v1
{
    public partial class BaslangicEkrani : Form
    {
        public BaslangicEkrani()
        {
            InitializeComponent();
        }
       
        private void btnOyna_Click(object sender, EventArgs e)
        {
            Form1 fm1 = new Form1();
            fm1.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOyunKurallari_Click(object sender, EventArgs e)
        {
            OyunKurallari ok = new OyunKurallari();
            ok.Show();
            this.Hide();
        }
    }
}
