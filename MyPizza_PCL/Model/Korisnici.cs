//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPizza_PCL.Model
{
    using System.Collections.Generic;

    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }
        public string Email { get; set; }
        public string BrojTelefona { get; set; }
        public System.DateTime DatumRegistracije { get; set; }
        public int StatusKorisnikaId { get; set; }
        public int GradId { get; set; }
        public string Ulica { get; set; }
        public List<UlogeKorisnika> Uloge { get; set; }
    }
}
