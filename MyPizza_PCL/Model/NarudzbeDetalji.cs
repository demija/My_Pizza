using System;

namespace MyPizza_PCL.Model
{
    public class NarudzbeDetalji
    {
        public int NarudzbaId { get; set; }
        public int NarudzbaPizzaId { get; set; }
        public int PizzaId { get; set; }
        public string Vrsta { get; set; }
        public string Velicina { get; set; }
        public string Promjer { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public Nullable<decimal> DodatniSastojciCjena { get; set; }
        public string Sastojci { get; set; }
    }
}