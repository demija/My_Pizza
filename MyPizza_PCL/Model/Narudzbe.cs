namespace MyPizza_PCL.Model
{
    using System;

    public partial class Narudzbe
    {    
        public int NarudzbaId { get; set; }
        public int KorisnikId { get; set; }
        public int StatusNarudzbeId { get; set; }
        public System.DateTime DatumNarudzbe { get; set; }
        public Nullable<bool> OtkazanaNarudzba { get; set; }
        public string AdresaZaDostavu { get; set; }
        public string BrojTelefona { get; set; }
    }
}
