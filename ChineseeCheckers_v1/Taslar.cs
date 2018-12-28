using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseeCheckers_v1
{
    class Taslar
    {
        public static int hamle = 0, hamlemavi = 0;
        TahtaOlustur tahta = new TahtaOlustur();
        public PictureBox pb,ps;
        public static int korx, kory, kormx, kormy;

        public static Boolean bt = false, st = false, kontrol = false;

        public static Taslar tsThis;

        private int x = 0, y = 0, v = 250, z = 250;
        public Taslar() {

            tsThis = this;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    beyazTas(x, y, i, j);
                    siyahTas(v, z, i, j);
                    v += 50;
                    x += 50;
                }
                y += 50;
                z += 50;
                x = 0;
                v = 250;
            }

            
        }

       public void beyazTas(int x, int y, int i, int j)
        {
            pb = new PictureBox();
            pb.Name = "pcb" + i + j;
            pb.Location = new System.Drawing.Point(x, y);
            pb.Size = new System.Drawing.Size(45, 45);
            pb.Image = ChineseeCheckers_v1.Properties.Resources.laci;
            pb.BackColor = System.Drawing.Color.Transparent;
            pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_MouseClick);
            Form1.frm.Controls.Add(pb);
            tahta.pt.Controls.Add(pb);


        }


        void siyahTas(int x, int y, int i, int j)
        {
            ps = new PictureBox();
            ps.Name = "pcs" + i + j;
            ps.Location = new System.Drawing.Point(x, y);
            ps.Size = new System.Drawing.Size(45, 45);
            ps.Image = ChineseeCheckers_v1.Properties.Resources.mor;
            ps.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ps.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ps_MouseClick);
            ps.BackColor = System.Drawing.Color.Transparent;
            Form1.frm.Controls.Add(ps);
            tahta.pt.Controls.Add(ps);

        }

        
        private void pb_MouseClick(object sender, MouseEventArgs e)
        {
            pb = (sender as PictureBox);
            bt = true;

            kormx = pb.Location.X;
            kormy = pb.Location.Y;

            hamlemavi++;
            Form1.frm.lblHamleMavi.Text = hamlemavi + "";

        }

       

        private void ps_MouseClick(object sender, MouseEventArgs e)
        {
            st = true;
            ps = (sender as PictureBox);
            
            korx = ps.Location.X;
            kory = ps.Location.Y;

           

            hamle++;
            Form1.frm.lblHamleMor.Text = hamle + "";
            
        }
        

    }
}
