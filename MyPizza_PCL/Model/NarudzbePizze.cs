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
    
    public partial class NarudzbePizze
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        /*public NarudzbePizze()
        {
            //this.DodatniSastojci = new HashSet<DodatniSastojci>();
        }*/
    
        public int NarudzbaPizzaId { get; set; }
        public int NarudzbaId { get; set; }
        public int PizzaId { get; set; }
        public int Kolicina { get; set; }
        public Nullable<double> Cijena { get; set; }
        
        public List<Sastojci> DodatniSastojci { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<DodatniSastojci> DodatniSastojci { get; set; }
        public virtual Narudzbe Narudzbe { get; set; }
        //public virtual Pizze Pizze { get; set; }
    }
}
