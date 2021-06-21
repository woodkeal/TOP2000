using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TOP2000UI.Models
{
    [Keyless]
    public class spNumberOfSongsArtist {
        public string Naam { get; set; }
        public int Nummers { get; set; }
    }
}
