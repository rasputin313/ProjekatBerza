using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PraviProjekatBerza;

namespace ProjekatBerza
{
    public class Akcije
    {
        private string imeAkcije;

        public string ImeAkcije
        {
            get { return imeAkcije; }
            set { imeAkcije = value; }
        }


        private double vrednostAkcije;

        public double VrednostAkcije
        {
            get { return vrednostAkcije; }
            set { vrednostAkcije = value; }
        }


        private int broj;

        public int Broj
        {
            get { return broj; }
            set { broj = value; }
        }


        private List<double>prethodneCene = new List<double>();

        public List<double> PrethodneCene
        {
            get { return prethodneCene; }
        }


        public Akcije(string imeAkcije, double vrednostAkcije, double IPO, int broj)
        {
            this.imeAkcije = imeAkcije;
            this.vrednostAkcije = vrednostAkcije;
            prethodneCene.Add(IPO);
            this.broj = broj;
        }
        public Akcije()
        {
            imeAkcije = "ImeAkcije";
            vrednostAkcije = 100;
            broj = 10;
        }

    }
}
