using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.ViewModels
{
    public class Top2000ViewModel
    {
        public string Title { get; set; }
        public int? Jaar { get; set; }
        public string ArtiestNaam { get; set; }
        [Key]
        public int songid { get; set; }
    }
}