using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeGra
{
    internal class GraSnake
    {
        public enum Kierunek { G, D, P, L };

        public delegate void metoda();
        public event metoda Zmiana;

        public delegate void metodaPunkt(Point p);
        public event metodaPunkt ZmianaPunkt;

        Random generator = new Random();
        Timer timer;
        public int Szerokosc { get; private set; }
        public int Wysokosc { get; private set; }
        public List<Point> Waz { get; private set; }
        public Kierunek K { get; set; }
        public Point Jablko { get; private set; }

        public GraSnake(int szerokosc, int wysokosc)
        {
            timer = new Timer();
            timer.Interval = 300;
            timer.Start();
            timer.Tick += Timer_Tick;

            this.Szerokosc = szerokosc;
            this.Wysokosc = wysokosc;

            Waz = new List<Point>();
            Waz.Add(new Point(szerokosc / 2, wysokosc - 3));
            Waz.Add(new Point(szerokosc / 2, wysokosc - 2));
            Waz.Add(new Point(szerokosc / 2, wysokosc - 1));
            K = Kierunek.G;
            LosujJablko();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Point nowaGlowa = Point.Empty;
            switch (K)
            {
                case Kierunek.G:
                    nowaGlowa = new Point(Waz[0].X, Waz[0].Y - 1);
                    break;
                case Kierunek.D:
                    nowaGlowa = new Point(Waz[0].X, Waz[0].Y + 1);
                    break;
                case Kierunek.L:
                    nowaGlowa = new Point(Waz[0].X - 1, Waz[0].Y);
                    break;
                case Kierunek.P:
                    nowaGlowa = new Point(Waz[0].X + 1, Waz[0].Y);
                    break;
            }
            //przejścia na drugą stronę planszy
            nowaGlowa.X = (nowaGlowa.X + Szerokosc) % Szerokosc;
            nowaGlowa.Y = (nowaGlowa.Y + Wysokosc) % Wysokosc;
            //sprawdzenie kolizji ze starym wężem
            if (Waz.Contains(nowaGlowa))
            {
                timer.Stop();
                MessageBox.Show("Koniec");
            }
            else
            {
                Waz.Insert(0, nowaGlowa);
                ZmianaPunkt?.Invoke(nowaGlowa);
            }
            //zjada jabłko
            if (Waz.First() == Jablko)
            {
                LosujJablko();
                ZmianaPunkt?.Invoke(Jablko);
                timer.Interval = (int)(timer.Interval * 0.95);
            }
            else
            {
                Point p = Waz.Last();
                Waz.Remove(Waz.Last());
                ZmianaPunkt?.Invoke(p);
            }
            //Zmiana?.Invoke();
            //if (Zmiana != null)
            //{
            //    Zmiana();
            //}
        }

        private void LosujJablko()
        {
            do
            {
                Jablko = new Point(generator.Next(Szerokosc), generator.Next(Wysokosc));
            } while (Waz.Contains(Jablko));
        }

        internal void Pauza()
        {
            timer.Enabled = !timer.Enabled;
        }
    }
}