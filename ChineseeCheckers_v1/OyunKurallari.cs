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
    public partial class OyunKurallari : Form
    {
        public OyunKurallari()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaslangicEkrani bs = new BaslangicEkrani();
            bs.Show();
            this.Close();
        }
    }
}
