using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseeCheckers_v1
{
    class Kontrol : Taslar
    {
        public static bool hamlesayisi = false;  // 1 kere oynamasının kontrol ettirme
        public static bool hamlesayisimavi = false;
        public Kontrol()
        {

        }

        public static int KontrolEt(int x, int y, int tx, int ty)
        {
            if ((x - 50 == tx && y == ty) || (x == tx && y - 50 == ty) || (x - 50 == tx && y - 50 == ty))
            {
                if (hamlesayisi == false)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            TahtaOlustur.tht.pt.Controls["pcs" + i + j].Enabled = false; //mor taşları eneabled yap oynayamasın
                        }
                    }
                    hamlesayisi = false;
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
            else if ((x - 100 == tx && y == ty) || (x == tx && y - 100 == ty))
            {
                hamlesayisi = true; //taşaırn üstüden atlaması için false olmaz
                return 3;
            }
            else
            {
                return 0;
            }
        }

        public static int SonrakiKontrol(int x, int y, int tx, int ty)
        {


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if ((x - 100 == tx && y == ty))
                    {
                        if (tx + 50 == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.X && ty == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.Y)
                        {
                            return 1;
                        }

                    }
                    else if ((x == tx && y - 100 == ty))
                    {
                        if (ty + 50 == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.Y && tx == TahtaOlustur.tht.pt.Controls["pcs" + i + j].Location.X)
                        {
                            return 2;
                        }


                    }

                }
            }
            return 0;
        }

        public static int MaviKontrolEt(int x, int y, int tx, int ty)
        {
            if ((x + 50 == tx && y == ty) || (x == tx && y + 50 == ty) || (x + 50 == tx && y + 50 == ty))
            {
                if (hamlesayisimavi == false)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            TahtaOlustur.tht.pt.Controls["pcb" + i + j].Enabled = false;
                        }
                    }
                    hamlesayisimavi = false;
                    return 1;

                }
                else
                {
                    return 0;
                }
            }
            else if ((x + 100 == tx && y == ty) || (x == tx && y + 100 == ty))
            {
                hamlesayisimavi = true;
                return 3;
            }
            else
            {
                return 0;
            }
        }


        public static int SonrakiKontrolMavi(int x, int y, int tx, int ty)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    if ((x + 100 == tx && y == ty))
                    {
                        if (tx - 50 == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.X && ty == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.Y)
                        {
                            return 1;
                        }
                    }
                    else if ((x == tx && y + 100 == ty))
                    {
                        if (ty - 50 == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.Y && tx == TahtaOlustur.tht.pt.Controls["pcb" + i + j].Location.X)
                        {
                            return 2;
                        }
                    }
                }
            }
            return 0;
        }

    }
}
