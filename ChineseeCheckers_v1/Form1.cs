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
    public partial class Form1 : Form
    {
        public static Form1 frm;
        BaslangicEkrani bs = new BaslangicEkrani();


        public Form1()
        {
            InitializeComponent();
            frm = this;
        }


        int sbittix = 350, sbittiy = 350, bittix = 0, bittiy = 0, kazandın;
        Taslar ts ;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnMorTm.Enabled = false;
            ts = new Taslar();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TahtaOlustur.tht.pt.Controls["pcs" + i + j].Enabled = false;
                    TahtaOlustur.tht.pt.Controls["pcb" + i + j].Enabled = true;
                }
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            bs.Show();
            this.Hide();
        }

        private void btnMaviTm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TahtaOlustur.tht.pt.Controls["pcb" + i + j].Enabled = false;
                    TahtaOlustur.tht.pt.Controls["pcs" + i + j].Enabled = true;
                    for (int k = 0; k < 3; k++)
                    {
                        if (sbittix == TahtaOlustur.tht.pt.Controls["pcb" + k + j].Location.X)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (sbittiy == TahtaOlustur.tht.pt.Controls["pcb" + k + l].Location.Y)
                                {
                                    kazandın++;

                                }
                            }
                            sbittix -= 50;
                            sbittiy -= 50;
                        }

                        sbittix = 350;
                    }

                }
            }
            sbittix = 350;
            sbittiy = 350;
            Kontrol.hamlesayisi = false;
            btnMaviTm.Enabled = false;
            btnMorTm.Enabled = true;
            if (kazandın == 9)
            {
                MessageBox.Show("Oyuncu 1 (Mavi) " + Taslar.hamlemavi + " hamle yaparak kazandı");

            }
            kazandın = 0;
        }

        private void btnMorTm_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    TahtaOlustur.tht.pt.Controls["pcs" + i + j].Enabled = false;
                    TahtaOlustur.tht.pt.Controls["pcb" + i + j].Enabled = true;
                    for (int k = 0; k < 3; k++)
                    {
                        if (bittix == TahtaOlustur.tht.pt.Controls["pcs" + k + j].Location.X)
                        {
                            for (int l = 0; l < 3; l++)
                            {
                                if (bittiy == TahtaOlustur.tht.pt.Controls["pcs" + k + l].Location.Y)
                                {
                                    kazandın++;

                                }
                            }
                            bittix += 50;
                            bittiy += 50;
                        }

                        bittix = 0;
                    }

                }
            }
            bittix = 0;
            bittiy = 0;
            Kontrol.hamlesayisi = false;
            btnMorTm.Enabled = false;
            btnMaviTm.Enabled = true;
            if (kazandın==9)
            {
                MessageBox.Show("Oyuncu 2 (Mor) "+Taslar.hamle+" hamle yaparak kazandı");
                
            }
            kazandın = 0;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ts = new Taslar();
        }

    }
}
