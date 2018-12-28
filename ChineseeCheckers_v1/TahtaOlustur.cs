using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseeCheckers_v1
{
    class TahtaOlustur
    {
        public static TahtaOlustur tht;
        public Panel pt;
        public int tahtaX, tahtaY ;
        int kontroletmor, kontroletmavi, sonraki, sonrakimavi, sonxs = 0, sonys = 0, sonxb = 350, sonyb = 350;

        public TahtaOlustur() {
            Tahta();
            tht = this;
        }
        

        void Tahta() {
            pt = new Panel();
            pt.Name = "pcb";
            pt.Location = new System.Drawing.Point(50, 50);
            pt.Size = new System.Drawing.Size(398, 398);
            pt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            pt.BackgroundImage = ChineseeCheckers_v1.Properties.Resources.tt;
            this.pt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pt_MouseDown);
            Form1.frm.Controls.Add(pt);
        }


        private void pt_MouseDown(object sender, MouseEventArgs e)
        {
            
            tahtaX = e.X;
            tahtaY = e.Y;

            tahtaX = tahtaX / 50;
            tahtaX = (tahtaX * 50);
            tahtaY = tahtaY / 50;
            tahtaY = (tahtaY * 50);

            Kontrol.hamlesayisi = false;
            Kontrol.hamlesayisimavi = false;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tahtaX == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.X && tahtaY == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.Y)
                    {
                        Taslar.bt = false; //taşların üs üste binmemesi için

                    }

                    if (tahtaX == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.X && tahtaY == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.Y)
                    {
                        Taslar.st = false;

                    }

                }
            }

            

            if (Taslar.st == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (sonxs == Taslar.tsThis.ps.Location.X)
                            {
                                if ((Taslar.korx + 50 == tahtaX && Taslar.kory == tahtaY) || (Taslar.korx == tahtaX && Taslar.kory + 50 == tahtaY) || (Taslar.korx + 50 == tahtaX && Taslar.kory + 50 == tahtaY))
                                {
                                    Taslar.tsThis.ps.Location = new System.Drawing.Point(tahtaX, tahtaY);
                                    kontroletmor = 6;
                                }

                            }
                            sonxs += 50;
                        }

                        sonys += 50;
                        sonxs = 0;
                    }
                }
                sonxs = 0;
                sonys = 0;
                if (kontroletmor != 6)  //tanımladığımız hamleye girmemesi için
                {
                    kontroletmor = Kontrol.KontrolEt(Taslar.korx, Taslar.kory, tahtaX, tahtaY);

                    if (kontroletmor == 1 || kontroletmor == 3)
                    {
                        if ((Taslar.korx - 100 == tahtaX && Taslar.kory == tahtaY) || (Taslar.korx == tahtaX && Taslar.kory - 100 == tahtaY))
                        {
                            sonraki = Kontrol.SonrakiKontrol(Taslar.korx, Taslar.kory, tahtaX, tahtaY);
                        }

                        if (sonraki == 1)
                        {

                            Taslar.tsThis.ps.Location = new System.Drawing.Point(tahtaX, tahtaY);
                        }
                        else if (sonraki == 2)
                        {
                            Taslar.tsThis.ps.Location = new System.Drawing.Point(tahtaX, tahtaY);

                        }

                        if (kontroletmor == 1)
                        {
                            Taslar.tsThis.ps.Location = new System.Drawing.Point(tahtaX, tahtaY);

                        }
                    }
                    else
                        MessageBox.Show("Yanlış Hamle!");
                }
                kontroletmor = 0;
                Taslar.st = false;



            }
            else if (Taslar.bt == true)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int k = 0; k < 3; k++)
                        {
                            if (sonxb == Taslar.tsThis.pb.Location.X)
                            {
                                if ((Taslar.kormx - 50 == tahtaX && Taslar.kormy == tahtaY) || (Taslar.kormx == tahtaX && Taslar.kormy - 50 == tahtaY) || (Taslar.kormx - 50 == tahtaX && Taslar.kormy - 50 == tahtaY))
                                {
                                    Taslar.tsThis.pb.Location = new System.Drawing.Point(tahtaX, tahtaY);
                                    kontroletmavi = 6;
                                }

                            }
                            sonxb -= 50;
                        }

                        sonyb -= 50;
                        sonxb = 350;
                    }
                }
                sonxb = 350;
                sonyb = 350;
                if (kontroletmavi != 6)
                {
                    kontroletmavi = Kontrol.MaviKontrolEt(Taslar.kormx, Taslar.kormy, tahtaX, tahtaY);




                    if (kontroletmavi == 1 || kontroletmavi == 3)
                    {
                        if ((Taslar.kormx + 100 == tahtaX && Taslar.kormy == tahtaY) || (Taslar.kormx == tahtaX && Taslar.kormy + 100 == tahtaY))
                        {
                            sonrakimavi = Kontrol.SonrakiKontrolMavi(Taslar.kormx, Taslar.kormy, tahtaX, tahtaY);

                        }

                        if (sonrakimavi == 1)
                        {

                            Taslar.tsThis.pb.Location = new System.Drawing.Point(tahtaX, tahtaY);
                        }
                        else if (sonrakimavi == 2)
                        {
                            Taslar.tsThis.pb.Location = new System.Drawing.Point(tahtaX, tahtaY);

                        }

                        if (kontroletmavi == 1)
                        {
                            Taslar.tsThis.pb.Location = new System.Drawing.Point(tahtaX, tahtaY);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Yanlış Hamle!");
                    }
                }
                kontroletmavi = 0;
                Taslar.bt = false;
            }
        }
    }
  }

