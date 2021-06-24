using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TOP2000UI.Models
{
    public class spSelectListingOnYear
    {
        public string Name { get; set; }
        public int Position { get; set; }
        public int Year { get; set; }
        public string Title { get; set; }
        [Key]
        public int ListYear { get; set; }

    }
}
