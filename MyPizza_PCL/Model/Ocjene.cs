using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_PCL.Model
{
    public class Ocjene
    {
        public int VrstaPizzeId { get; set; }
        public int KorisnikId { get; set; }
        public System.DateTime DatumOcjene { get; set; }
        public bool SvidjaSe { get; set; }
        public bool NeSvidjaSe { get; set; }
    }
}
