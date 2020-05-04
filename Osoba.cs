using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekatBerza
{
    class Osoba
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private double novac;


        public double Novac
        {
            get { return novac; }
            set { novac = value; }
        }


        List<Akcije> listaAkcija = new List<Akcije>();
        List<int> brojAkcija = new List<int>();

        List<Nekretnine> listaNekretnina = new List<Nekretnine>();
        List<int> brojNekretnina = new List<int>();

        List<Resursi> listaResursa = new List<Resursi>();
        List<int> brojGrama = new List<int>();
    }
}
