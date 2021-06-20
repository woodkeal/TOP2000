using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spSelectAllArtistsController : Controller
    {
        public IActionResult Index()
        {
            var dbContext = new TOP2000Context();
            var allArtists = dbContext.spSelectAllArtists.FromSqlRaw($"spSelectAllArtists").ToList();
            return View(allArtists);
        }
    }
}
