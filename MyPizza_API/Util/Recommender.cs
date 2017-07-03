using System;
using System.Collections.Generic;
using System.Linq;
using MyPizza_API.Models;

namespace MyPizza_API.Util
{
    public class Recommender
    {
        MyPizzaEntities1 db = new MyPizzaEntities1();
        Dictionary<int, List<Ocjene>> proizvodi = new Dictionary<int, List<Ocjene>>();

        public List<VrstePizza> GetSlicneProizvode(int proizvodId)
        {
            UcitajProizvode(proizvodId);
            List<Ocjene> ocjenePosmatranogProizvoda = db.Ocjene.Where(x => x.VrstaPizzeId == proizvodId).OrderBy(x => x.KorisnikId).ToList();

            List<Ocjene> zajednickeOcjene1 = new List<Ocjene>();
            List<Ocjene> zajednickeOcjene2 = new List<Ocjene>();
            List<VrstePizza> preporuceniProizvodi = new List<VrstePizza>();

            foreach (var item in proizvodi)
            {
                foreach (Ocjene o in ocjenePosmatranogProizvoda)
                {
                    if (item.Value.Where(x => x.KorisnikId == o.KorisnikId).Count() > 0)
                    {
                        zajednickeOcjene1.Add(o);
                        zajednickeOcjene2.Add(item.Value.Where(x => x.KorisnikId == o.KorisnikId).First());
                    }
                }

                double slicnost = GetSlicnost(zajednickeOcjene1, zajednickeOcjene2);

                if (slicnost > 0.5)
                {
                    preporuceniProizvodi.Add(db.myPizza_VrstePizza_SelectById(item.Key).FirstOrDefault());
                }

                zajednickeOcjene1.Clear();
                zajednickeOcjene2.Clear();
            }

            return preporuceniProizvodi;
        }

        private double GetSlicnost(List<Ocjene> zajednickeOcjene1, List<Ocjene> zajednickeOcjene2)
        {
            if (zajednickeOcjene1.Count != zajednickeOcjene2.Count)
            {
                return 0;
            }

            double brojnik = 0;
            double nazivnik1 = 0;
            double nazivnik2 = 0;

            for (int i = 0; i < zajednickeOcjene1.Count; i++)
            {
                brojnik = zajednickeOcjene1[i].Ocjena * zajednickeOcjene2[i].Ocjena;
                nazivnik1 = zajednickeOcjene1[i].Ocjena * zajednickeOcjene1[i].Ocjena;
                nazivnik2 = zajednickeOcjene2[i].Ocjena * zajednickeOcjene2[i].Ocjena;
            }

            nazivnik1 = Math.Sqrt(nazivnik1);
            nazivnik2 = Math.Sqrt(nazivnik2);

            double nazivnik = nazivnik1 * nazivnik2;

            if (nazivnik == 0)
            {
                return 0;
            }
            else
            {
                return brojnik / nazivnik;
            }
        }

        private void UcitajProizvode(int proizvodId)
        {
            List<VrstePizza> aktivniProizvodi = db.VrstePizza.Where(x => x.VrstaPizzeId != proizvodId).ToList();
            List<Ocjene> ocjene;

            foreach (VrstePizza item in aktivniProizvodi)
            {
                ocjene = db.Ocjene.Where(x => x.VrstaPizzeId == item.VrstaPizzeId).OrderBy(x => x.KorisnikId).ToList();

                if (ocjene.Count > 0)
                {
                    proizvodi.Add(item.VrstaPizzeId, ocjene);
                }
            }
        }
    }
}