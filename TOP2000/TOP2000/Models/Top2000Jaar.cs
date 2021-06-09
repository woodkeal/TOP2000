﻿using System;
using System.Collections.Generic;

#nullable disable

namespace TOP2000.Models
{
    public partial class Top2000Jaar
    {
        public Top2000Jaar()
        {
            Lijsts = new HashSet<Lijst>();
        }

        public int Jaar { get; set; }
        public string Titel { get; set; }

        public virtual ICollection<Lijst> Lijsts { get; set; }
    }
}
