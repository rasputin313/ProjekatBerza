using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
    enum VrstaSmestaja
    {
        Stan,
        Kuca
    }
    class Nekretnine
    {
        private double x;

        public double X
        {
            get { return x; }
            set { x = value; }
        }


        private double y;

        public double Y
        {
            get { return y; }
            set { y = value; }
        }


        private double vrednostNekretnine;

        public double VrednostNekretnine
        {
            get { return vrednostNekretnine; }
            set { vrednostNekretnine = value; }
        }


        private VrstaSmestaja tipSmestaja;

        public VrstaSmestaja TipSmestaja
        {
            get { return tipSmestaja; }
            set { tipSmestaja = value; }
        }


        private List<double> prethodneCene = new List<double>();

        public List<double> PrethodneCene
        {
            get { return prethodneCene; }
        }


        private double cenaClanarine;

        public double CenaClanarine
        {
            get { return cenaClanarine; }
            set { cenaClanarine = value; }
        }

        public Nekretnine(double x, double y, double vrednostNekretnine, VrstaSmestaja tipSmestaja, double cenaClanarine, int IPO)
        {
            this.x = x;
            this.y = y;
            this.vrednostNekretnine = vrednostNekretnine;
            this.tipSmestaja = tipSmestaja;
            this.cenaClanarine = cenaClanarine;
            prethodneCene.Add(IPO);
        }
    }
}
