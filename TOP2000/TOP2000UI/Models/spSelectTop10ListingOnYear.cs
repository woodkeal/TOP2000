using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TOP2000UI.Models
{
    [Keyless]
    public class spTop10ListingOnYear
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        public int ListYear { get; set; }
        public string Difference { get; set; }
    }
}
