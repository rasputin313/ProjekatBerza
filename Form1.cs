using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatBerza;

namespace PraviProjekatBerza
{
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();
        }


        private Osoba osoba = new Osoba();

        public Osoba Osoba

        {
            get { return osoba; }
            set { osoba = value; }
        }


        private Berza berza;

        public Berza Berza
        {
            get { return berza; }
            set { berza = value; }
        }

        


        private void pnlMeni_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = frmMain.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }
            g.DrawLine(new Pen(Color.Black), frmMain.Width / 2, 50, frmMain.Width / 2, frmMain.Height);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 20);
            g.DrawString("Choose your fighter:", font, Brushes.Black, 60, 10);
        }

        private void btnNiceGuy_Click(object sender, EventArgs e)
        {
            if(brojacNiceGuy == 0)
            {
                Akcije akcija = new Akcije("TSLA", 900, 40, 10);
                Akcije akcija2 = new Akcije("ABN", 300, 20, 10);
                Resursi resurs = new Resursi("Etiopija", 56, VrstaResursa.Zlato, 10);
                Nekretnine nekretnina = new Nekretnine(123000, VrstaSmestaja.Kuca, 500);
                osoba.ListaAkcija.Add(akcija);
                osoba.ListaAkcija.Add(akcija2);
                osoba.ListaResursa.Add(resurs);
                osoba.ListaNekretnina.Add(nekretnina);
                osoba.Novac = 14;
            }
            frmOsoba frmOsoba = new frmOsoba(osoba, berza);
            if (frmOsoba.ShowDialog() != DialogResult.OK)
                return;
        }

        private void btnShrek_Click(object sender, EventArgs e)
        {
            Akcije akcija = new Akcije("TSLA", 900, 40, 10);
            Resursi resurs = new Resursi("Etiopija", 56, VrstaResursa.Zlato, 10);
            Nekretnine nekretnina = new Nekretnine(123000, VrstaSmestaja.Kuca, 500);
            osoba.ListaAkcija.Add(akcija);
            osoba.ListaResursa.Add(resurs);
            osoba.ListaNekretnina.Add(nekretnina);
            osoba.Novac = 14;
            frmOsoba frmOsoba = new frmOsoba(osoba, berza);
            if (frmOsoba.ShowDialog() != DialogResult.OK)
                return;
        }
    }
}
