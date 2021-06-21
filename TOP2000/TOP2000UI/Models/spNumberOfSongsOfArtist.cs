using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TOP2000UI.Models
{
    [Keyless]
    public class spNumberOfSongsOfArtist {
        public string naam { get; set; }
        public int nummers { get; set; }
    }
}
