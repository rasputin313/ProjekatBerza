using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjekatBerza;

namespace PraviProjekatBerza
{
    public partial class frmIzvidiAkciju : Form
    {
        public frmIzvidiAkciju(Akcije akcija)
        {
            InitializeComponent();
            MessageBox.Show(akcija.ImeAkcije);

        }
    }
}
