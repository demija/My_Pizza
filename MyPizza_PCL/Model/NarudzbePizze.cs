namespace MyPizza_PCL.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class NarudzbePizze
    {
        public int NarudzbaPizzaId { get; set; }
        public int NarudzbaId { get; set; }
        public int PizzaId { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public List<Sastojci> DodatniSastojci { get; set; }
        public string Vrsta { get; set; }
        public string Velicina { get; set; }
        public string dodajtniSastojciOpis { get; set; }
        public virtual Narudzbe Narudzbe { get; set; }
    }
}
