using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Bitmap obraz;
        Graphics g;

        bool czyMoznaRysowac = false;
        Point start, koniec;
        Pen olowek;
        Pen gumka;
        ColorDialog oknoKoloru;

        int narzedzie;

        int szerokosc, wysokosc;

        private void btnOlowek_Click(object sender, EventArgs e)
        {
            narzedzie = 1;
        }

        private void btnGumka_Click(object sender, EventArgs e)
        {
            narzedzie = 2;
        }

        private void btnElipsa_Click(object sender, EventArgs e)
        {
            narzedzie = 3;
        }

        private void btnProstokat_Click(object sender, EventArgs e)
        {
            narzedzie = 4;
        }

        private void btnLinia_Click(object sender, EventArgs e)
        {
            narzedzie = 5;
        }

        private void pbKarta_MouseDown(object sender, MouseEventArgs e)
        {
            czyMoznaRysowac = true;
            start = e.Location;
            startX= e.X;
            startY= e.Y;
        }

        private void pbKarta_MouseMove(object sender, MouseEventArgs e)
        {
            if(czyMoznaRysowac == true)
            {
                if(narzedzie == 1)
                {
                    koniec = e.Location;
                    g.DrawLine(olowek, start, koniec);
                    start = koniec;
                    
                }
                else if (narzedzie == 2)
                {
                    koniec = e.Location;
                    g.DrawLine(gumka, start, koniec);
                    start = koniec;

                }


            }
            pbKarta.Refresh();
            koniecX = e.Location.X;
            koniecY = e.Location.Y;
            szerokosc = koniecX - startX;
            wysokosc = koniecY - startY;
        }

        private void pbKarta_MouseUp(object sender, MouseEventArgs e)
        {
            czyMoznaRysowac = false;
            if(narzedzie == 3)
            {
                g.DrawEllipse(olowek, startX, startY, szerokosc, wysokosc);
            }else if(narzedzie == 4)
            {
                g.DrawRectangle(olowek, startX, startY, szerokosc, wysokosc);
            }else if (narzedzie == 5)
            {
                g.DrawLine(olowek, startX, startY, koniecX,koniecY);
            }
        }

        private void pbKolor_Click(object sender, EventArgs e)
        {
            oknoKoloru.ShowDialog();
            olowek.Color = oknoKoloru.Color;
            pbKolor.BackColor = oknoKoloru.Color;
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pbKarta.Image = obraz;
        }

        private void pbKarta_Paint(object sender, PaintEventArgs e)
        {
            Graphics g2 = e.Graphics;
            if(czyMoznaRysowac == true)
            {
                if (narzedzie == 3)
                {
                    g2.DrawEllipse(olowek, startX, startY, szerokosc, wysokosc);
                }
                else if (narzedzie == 4)
                {
                    g2.DrawRectangle(olowek, startX, startY, szerokosc, wysokosc);
                }
                else if (narzedzie == 5)
                {
                    g2.DrawLine(olowek, startX, startY, koniecX, koniecY);
                }
            }
        }

        int startX, startY, koniecX, koniecY;
        public Form1()
        {
            InitializeComponent();

            obraz = new Bitmap(pbKarta.Width, pbKarta.Height);
            g = Graphics.FromImage(obraz);
            pbKarta.Image = obraz;
            pbKolor.BackColor = Color.Black;
            olowek = new Pen(Color.Black, 1);
            gumka = new Pen(Color.White, 10);
            oknoKoloru = new ColorDialog();
        }

       
    }
}
