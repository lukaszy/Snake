using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGra
{
    public partial class FormGlowneOkno : Form
    {
        Graphics g;
        Int32 rozmiarPola;
        GraSnake gra;
        public FormGlowneOkno()
        {
            InitializeComponent();

            menu_Click(standardowaToolStripMenuItem, null);
            pbWizualizacja_SizeChanged(null, null);
        }

        private void OdrysujCalosc()
        {
            g.Clear(Color.White);
            for (int x = 0; x < gra.Szerokosc; x++)
            {
                for (int y = 0; y < gra.Wysokosc; y++)
                {
                    g.DrawRectangle(new Pen(Color.Gray, 2),
                                    x * rozmiarPola,
                                    y * rozmiarPola,
                                    rozmiarPola,
                                    rozmiarPola
                                    );
                }
            }
            g.FillEllipse(new SolidBrush(Color.Red),
                                    gra.Jablko.X * rozmiarPola + 1,
                                    gra.Jablko.Y * rozmiarPola + 1,
                                    rozmiarPola - 2,
                                    rozmiarPola - 2
                                    );
            foreach (Point p in gra.Waz)
            {
                g.FillEllipse(new SolidBrush(Color.Green),
                                    p.X * rozmiarPola + 1,
                                    p.Y * rozmiarPola + 1,
                                    rozmiarPola - 2,
                                    rozmiarPola - 2
                                    );
            }
            pbWizualizacja.Refresh();
        }

        private void menu_Click(object sender, EventArgs e)
        {
            int szer = 0;
            int wys = 0;
            if (sender == malaToolStripMenuItem)
            {
                szer = 10;
                wys = 7;
            }
            else if (sender == standardowaToolStripMenuItem)
            {
                szer = 20;
                wys = 14;
            }
            else if (sender == duzaToolStripMenuItem)
            {
                szer = 30;
                wys = 21;
            }
            gra = new GraSnake(szer, wys);
            gra.Zmiana += OdrysujCalosc;
            gra.ZmianaPunkt += OdrysujPunkt;
            pbWizualizacja_SizeChanged(null, null);
        }

        private void OdrysujPunkt(Point p)
        {
            Color c;
            if (gra.Waz.Contains(p))
            {
                c = Color.Green;
            }
            else if (gra.Jablko == p)
            {
                c = Color.Red;
            }
            else
            {
                c = Color.White;
            }
            g.FillEllipse(new SolidBrush(c),
                                    p.X * rozmiarPola + 1,
                                    p.Y * rozmiarPola + 1,
                                    rozmiarPola - 2,
                                    rozmiarPola - 2
                                    );
            pbWizualizacja.Refresh();
        }

        private void pbWizualizacja_SizeChanged(object sender, EventArgs e)
        {
            pbWizualizacja.Image = new Bitmap(pbWizualizacja.Width, pbWizualizacja.Height);
            g = Graphics.FromImage(pbWizualizacja.Image);

            rozmiarPola = Math.Min(pbWizualizacja.Width / gra.Szerokosc,
                                   pbWizualizacja.Height / gra.Wysokosc);

            //przesuniecie punktu (0,0) dla graphics g
            //tak żeby plansza rysowała się na środku pbWizualizacja
            g.TranslateTransform((pbWizualizacja.Width - gra.Szerokosc * rozmiarPola) / 2,
                                 (pbWizualizacja.Height - gra.Wysokosc * rozmiarPola) / 2);

            OdrysujCalosc();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    gra.K = GraSnake.Kierunek.G;
                    break;
                case Keys.Down:
                    gra.K = GraSnake.Kierunek.D;
                    break;
                case Keys.Left:
                    gra.K = GraSnake.Kierunek.L;
                    break;
                case Keys.Right:
                    gra.K = GraSnake.Kierunek.P;
                    break;
                case Keys.Space:
                    gra.Pauza();
                    break;
            }
        }
    }
}
