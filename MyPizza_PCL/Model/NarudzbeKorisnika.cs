﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPizza_PCL.Model
{
    public class NarudzbeKorisnika
    {
        public int NarudzbaId { get; set; }
        public int NarudzbaPizzaId { get; set; }
        public int PizzaId { get; set; }
        public string Vrsta { get; set; }
        public string Velicina { get; set; }
        public string Promjer { get; set; }
        public int Kolicina { get; set; }
        public Nullable<decimal> Cijena { get; set; }
        public string AdresaZaDostavu { get; set; }
        public string BrojTelefona { get; set; }
        public Nullable<decimal> DodatniSastojciCjena { get; set; }
        public string Sastojci { get; set; }
    }
}