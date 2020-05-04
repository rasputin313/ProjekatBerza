using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
    enum VrstaResursa
    {
        Zlato,
        Nafta,
        Dijamanti
    }
    class Resursi
    {
        private string zemljaPorekla;

        public string ZemljaPorekla
        {
            get { return zemljaPorekla; }
            set { zemljaPorekla = value; }
        }


        private double vrednostGrama;

        public double VrednostResursa
        {
            get { return vrednostGrama; }
            set { vrednostGrama = value; }
        }


        private VrstaResursa tipResursa;

        public VrstaResursa TipResursa
        {
            get { return tipResursa; }
            set { tipResursa = value; }
        }


        private List<double> prethodneCene = new List<double>();

        public List<double> PrethodneCene
        {
            get { return prethodneCene; }
        }


        public Resursi(string zemljaPorekla, double vrednostResursa, VrstaResursa tipResursa, int IPO)
        {
            this.zemljaPorekla = zemljaPorekla;
            this.vrednostGrama = vrednostResursa;
            this.tipResursa = tipResursa;
            prethodneCene.Add(IPO);
        }
    }
}
