using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiBi.Models
{
    public class Marki_avtomobiley
    {
        public long ID { get; set; }
        public string Naimenovanie { get; set; }
        public string Tech_harakteristiki { get; set; }
        public string Opisanie { get; set; }

    }
}
