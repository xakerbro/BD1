using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Dop_yslygi
    {
        public long ID { get; set; }
        public string Naimenovanie { get; set; }
        public string Opisanie { get; set; }
        public int Cena { get; set; }
        public long Kod_prokata { get; set; }
        public long Kod_yslygi_3Kod_prokata { get; set; }
        public long Kod_yslygi_2Kod_prokata { get; set; }
        public DbSet<Prokat> Prokat { get; set; }


    }
}
