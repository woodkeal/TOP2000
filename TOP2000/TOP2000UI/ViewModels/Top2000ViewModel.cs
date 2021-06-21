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
        public int Positie { get; set; }
        public string Title { get; set; }
        public string ArtiestNaam { get; set; }
        public int? Jaar { get; set; }
    }
}