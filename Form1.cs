using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraviProjekatBerza
{
    public partial class frmMeni : Form
    {
        public frmMeni()
        {
            InitializeComponent();

        }

        private void pnlMeni_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnlMeni.CreateGraphics();
            g.DrawLine(new Pen(Color.Black), pnlMeni.Width / 2, 0, pnlMeni.Width / 2, pnlMeni.Height);
        }
    }
}
