using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
    class Akcije
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


        private List<double>prethodneCene = new List<double>();

        public List<double> PrethodneCene
        {
            get { return prethodneCene; }
        }


        public Akcije(string imeAkcije, double vrednostAkcije, double IPO)
        {
            this.imeAkcije = imeAkcije;
            this.vrednostAkcije = vrednostAkcije;
            prethodneCene.Add(IPO);
        }

    }
}
