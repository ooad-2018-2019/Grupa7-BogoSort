﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaxiDispecer.Models
{
    public class Obavijest
    {
        [ScaffoldColumn(false)]
        public int ObavijestID { get; set; }
       
        public int OsobaID { get; set; }

        public virtual Osoba Osoba { get; set; }

        public DateTime DateTime { get; set; }

        public String TekstObavijesti { get; set; }
    }
}
