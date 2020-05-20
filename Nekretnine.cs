using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
   public enum VrstaSmestaja
    {
        Stan,
        Kuca
    }
    public class Nekretnine
    {

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


       /* private List<double> prethodneCene = new List<double>();

        public List<double> PrethodneCene
        {
            get { return prethodneCene; }
        }*/


        private double cenaClanarine;

        public double CenaClanarine
        {
            get { return cenaClanarine; }
            set { cenaClanarine = value; }
        }

        public Nekretnine(double vrednostNekretnine, VrstaSmestaja tipSmestaja, double cenaClanarine/*, int IPO*/)
        {
            this.vrednostNekretnine = vrednostNekretnine;
            this.tipSmestaja = tipSmestaja;
            this.cenaClanarine = cenaClanarine;
            //prethodneCene.Add(IPO);
        }
    }
}
