using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Sotrudniki
    {
        public long ID { get; set; }
        public string FIO { get; set; }
        public int Vozrast { get; set; }
        public string Pol { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string Pasportnie_dannie { get; set; }
        public DbSet<Prokat> Kod_prokata { get; set; }
        public DbSet<Avtomobili> Kod_avto { get; set; }
    }
}
