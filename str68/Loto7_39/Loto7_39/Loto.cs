using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loto7_39
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }
        /// <summary>
        /// Konstruktor klase Loto
        /// </summary>
        public Loto()
        {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        }
        /// <summary>
        /// Dodaje korisničke vrijednosti u listu uplačćenih brojeva. Svaka vrijednost se provjerava i uzima u obzir ako je u rasponu 1-39 i ako već ne postoji.
        /// </summary>
        /// <param name="korisnickeVrijednosti">Vrijednosti koje je unio korisnik</param>
        /// <returns>True ako se u listi nalazi 7 jedinstvenih brojeva od 1 do 39, u suprotnom false.</returns>
        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti)
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();
            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {
                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;
            }
            return ispravni;
        }
        /// <summary>
        /// Generira 7 nasumičnih jedinstvenih cijelih brojeva od 1 do 39, te ih sprema u listu kao dobitnu kombinaciju brojeva
        /// </summary>
        public void GenerirajDobitnuKombinaciju()
        {
            DobitniBrojevi.Clear();
            Random generatorBrojeva = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = generatorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }

        public int IzracunajBrojPogodaka()
        {
            int brojPogodaka = 0;
            foreach(int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj) == true)
                {
                    brojPogodaka++;
                }
            }
            return brojPogodaka;
        }
    }
}
