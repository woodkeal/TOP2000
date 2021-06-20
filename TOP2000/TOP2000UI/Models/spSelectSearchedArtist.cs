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
        public string naam { get; set; }
        public string titel { get; set; }
        public int jaar { get; set; }
    }
}
