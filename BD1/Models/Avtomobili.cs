using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Avtomobili
    {
        public long ID { get; set; }
        public int Registr_nomer { get; set; }
        public int Nomer_kyzova { get; set; }
        public int Nomer_dvigatelya { get; set; }
        public DateTime God_vipyska { get; set; }
        public int Probeg { get; set; }
        public int Cena_avto { get; set; }
        public int Cena_dlya_prokata { get; set; }
        public DateTime Data_poslednego_TO { get; set; }
        public string Spec_otmetki { get; set; }
        public string Otmetka_o_vozraste { get; set; }
        public DbSet<Marki_avtomobiley> Kod_marki { get; set; }
        public DbSet<Prokat> Kod_prokata { get; set; }
        
    }
}
