using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vjclass.AutomotiveClasses
{
    abstract class Vozilo
    {
        private List<Dio> montiraniDijelovi;
        public VIN idAutomobila;
        public string naziv { get; set; }
        public int status { get; set; }
        public int tezina { get; set; }
        public int visina { get; set; }
        public int duzina { get; set; }
        public int meduosovinskiRazmak { get; set; }
        public String gume { get; set; }
        public int co2 { get; set; }

        public Vozilo()
        {
            montiraniDijelovi = new List<Dio>();
            idAutomobila = new VIN(10,15,54);
        }

        public bool addDio(Dio noviDio)
        {
            montiraniDijelovi.Add(noviDio);
            return true;
        }

        public void updateStatus()
        {
            status = status++;
        }

        public List<Dio> getDijelovi()
        {
            return montiraniDijelovi;
        }
    }
}
