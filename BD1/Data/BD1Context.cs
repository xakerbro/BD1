using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DiBi.Models;

namespace BD1.Data
{
    public class BD1Context : DbContext
    {
        public BD1Context (DbContextOptions<BD1Context> options)
            : base(options)
        {
        }

        public DbSet<DiBi.Models.Avtomobili> Avtomobili { get; set; }

        public DbSet<DiBi.Models.Sotrudniki> Sotrudniki { get; set; }

        public DbSet<DiBi.Models.Doljnosti> Doljnosti { get; set; }

        public DbSet<DiBi.Models.Dop_yslygi> Dop_yslygi { get; set; }

        public DbSet<DiBi.Models.Klienti> Klienti { get; set; }

        public DbSet<DiBi.Models.Marki_avtomobiley> Marki_avtomobiley { get; set; }

        public DbSet<DiBi.Models.Prokat> Prokat { get; set; }
    }
}
