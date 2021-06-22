using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOP2000UI.Models
{
    [Keyless]
    public class spSelectSearchedArtist
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
