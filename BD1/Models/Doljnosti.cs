using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Doljnosti
    {
        public long ID { get; set; }
        public string Naimenovanie_doljnosti { get; set; }
        public int Oklad { get; set; }
        public string Trebovaniya { get; set; }
        public string Obyazanosti { get; set; }
        public DbSet<Sotrudniki> Kod_sotrudnika { get; set; }


    }
}
