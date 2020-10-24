using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Prokat
    {
        public DateTime Data_vidachi { get; set; }
        public DateTime Srok_prokata { get; set; }
        public DateTime Data_vozvrata { get; set; }
        public int Cena_prokata { get; set; }
        public string Otmetka_ob_oplate { get; set; }
        public long ID { get; set; }



    }
}
