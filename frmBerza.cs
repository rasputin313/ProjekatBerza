using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace PraviProjekatBerza
{
    public partial class frmBerza : Form
    {
        public frmBerza(Berza berza)
        {
            InitializeComponent();
        }

        private void pnlBerza_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlBerza.CreateGraphics();
            using (var brush = new LinearGradientBrush(DisplayRectangle, Color.Green, Color.DarkGray, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, DisplayRectangle);
            }

            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3, 60, pnlBerza.Width / 3, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3, 60, pnlBerza.Width / 3, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), pnlBerza.Width / 3 * 2, 60, pnlBerza.Width / 3 * 2, pnlBerza.Height - 60);
            g.DrawLine(new Pen(Color.Black), 10, 90, pnlBerza.Width - 10, 90);

            System.Drawing.Font font = new System.Drawing.Font("Arial", 30);
            g.DrawString("Berza", font, Brushes.Black,pnlBerza.Width/2 - 60 , 10);

            System.Drawing.Font font2 = new System.Drawing.Font("Arial", 15);
            g.DrawString("Akcije", font2, Brushes.Black, pnlBerza.Width / 6 - 40, 70);
            g.DrawString("Resursi", font2, Brushes.Black, pnlBerza.Width / 2 - 45, 70);
            g.DrawString("Nekretnine", font2, Brushes.Black, pnlBerza.Width / 6 * 5 - 60, 70);





        }
    }
}
