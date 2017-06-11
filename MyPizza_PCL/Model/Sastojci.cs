using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_PCL.Model
{
    public class Sastojci
    {
        public int SastojakId { get; set; }
        public string Sastojak { get; set; }
        public double BaznaCijena { get; set; }
        public double DodatnaCijena { get; set; }
    }
}
