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
    using System;
    using System.Collections.Generic;
    
    public class Korisnici
    {
        /*[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnici()
        {
            this.KorisnickeUloge = new HashSet<KorisnickeUloge>();
            this.Narudzbe = new HashSet<Narudzbe>();
            this.Ocjene = new HashSet<Ocjene>();
            this.Racuni = new HashSet<Racuni>();
        }*/
    
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

        /*public virtual Gradovi Gradovi { get; set; }
        public virtual StatusiKorisnika StatusiKorisnika { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KorisnickeUloge> KorisnickeUloge { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzbe> Narudzbe { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ocjene> Ocjene { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racuni> Racuni { get; set; }*/
    }
}
