using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_PCL.Model
{
    public class VrstePizza
    {
        public int VrstaPizzeId { get; set; }
        public string Vrsta { get; set; }
        public string Opis { get; set; }
        public System.DateTime DatumDodavanja { get; set; }
        public Nullable<System.DateTime> DatumIzmjene { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    }
}
