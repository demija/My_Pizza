namespace MyPizza_PCL.Model
{
    class RacuniKorisnika
    {
        public int RacunId { get; set; }
        public System.DateTime Datum { get; set; }
        public decimal CijenaBezPDV { get; set; }
        public decimal CijenaSaPDV { get; set; }
        public string StatusNarudzbe { get; set; }
        public string Vrsta { get; set; }
        public string Velicina { get; set; }
        public string Promjer { get; set; }
        public int Kolicina { get; set; }
        public string AdresaZaDostavu { get; set; }
        public string BrojTelefona { get; set; }
    }
}