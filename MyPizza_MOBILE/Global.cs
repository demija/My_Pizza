using MyPizza_PCL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_MOBILE
{
    public class Global
    {
        public static Korisnici prijavljeniKorisnik { get; set; }
        public static Narudzbe narudzba { get; set; }
        public static List<NarudzbePizze> narudzbePizze { get; set; }
        //public static Sastojci dodatniSastojci { get; set; }
    }
}
