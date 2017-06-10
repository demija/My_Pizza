using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_PCL.Model
{
    public class myPizza_GetPizzaPriceByVrsta_Result
    {
        public int PizzaId { get; set; }
        public int VrstaId { get; set; }
        public int VelicinaId { get; set; }
        public int Cijena { get; set; }
        //public int StatusPizzeId { get; set; }
        //public Nullable<double> Cijena { get; set; }
    }
}