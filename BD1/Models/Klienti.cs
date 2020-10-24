using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Klienti
    {
        public long ID { get; set; }
        public string FIO { get; set; }
        public int Pol { get; set; }
        public DateTime Data_rojdenia { get; set; }
        public string Adres { get; set; }
        public int Telefon { get; set; }
        public string Pasportnie_dannie { get; set; }
        public DbSet<Prokat> Kod_prokata { get; set; }


    }
}
