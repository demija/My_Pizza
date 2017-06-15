namespace MyPizza_PCL.Model
{
    public class Sastojci
    {
        public int SastojakId { get; set; }
        public int NarudzbaPizzaId { get; set; }
        public string Sastojak { get; set; }
        public decimal BaznaCijena { get; set; }
        public decimal DodatnaCijena { get; set; }
    }
}
