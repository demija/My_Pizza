namespace MyPizza_PCL.Model
{
    public class Racuni
    {
        public int RacunId { get; set; }
        public System.DateTime Datum { get; set; }
        public int NarudzbaId { get; set; }
        public int KorisnikId { get; set; }
        public decimal CijenaSaPDV { get; set; }
        public decimal CijenaBezPDV { get; set; }
    }
}
