//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyPizza_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VrstePizza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VrstePizza()
        {
            this.Pizze = new HashSet<Pizze>();
            this.VrsteSastojci = new HashSet<VrsteSastojci>();
        }
    
        public int VrstaPizzeId { get; set; }
        public string Vrsta { get; set; }
        public string Opis { get; set; }
        public System.DateTime DatumDodavanja { get; set; }
        public Nullable<System.DateTime> DatumIzmjene { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Pizze> Pizze { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VrsteSastojci> VrsteSastojci { get; set; }
    }
}
