using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.ViewModels
{
    [Keyless]
    public class Top2000ViewModel
    {
        public int Position { get; set; }
        public string Difference { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int? Year { get; set; }
        public int ListYear { get; set; }
    }
}