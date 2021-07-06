using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spNumberOfSongsOfArtistController : Controller
    {
        public IActionResult Index()
        {
            var dbContext = new TOP2000Context();

            //calls stored procedure and put it in a list
            var Number = dbContext.spNumberofSongsOfArtist.FromSqlRaw($"spNumberOfSongsOfArtist").ToList();

            return View(Number);
        }
    }
}
