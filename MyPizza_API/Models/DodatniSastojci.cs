
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
    
public partial class DodatniSastojci
{

    public int DodatniSastojakId { get; set; }

    public int NarudzbaPizzaId { get; set; }

    public int SastojakId { get; set; }



    public virtual NarudzbePizze NarudzbePizze { get; set; }

    public virtual Sastojci Sastojci { get; set; }

}

}
