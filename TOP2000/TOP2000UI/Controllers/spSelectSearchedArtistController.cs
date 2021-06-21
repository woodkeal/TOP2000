using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spSelectSearchedArtistController : Controller
    {
        public ActionResult Index(string artistName)
        {
            var dbContext = new TOP2000Context();
            List<spSelectSearchedArtist> searchedArtist = new List<spSelectSearchedArtist>();
            if (artistName != null)
            {
                searchedArtist = dbContext.spSelectSearchedArtist.FromSqlRaw($"spSelectSearchedArtist {artistName}").ToList();
            } else
            {
                searchedArtist = dbContext.spSelectSearchedArtist.FromSqlRaw($"spSelectSearchedArtist abba").ToList();
            }
            
            return View(searchedArtist);
        }

        [HttpPost]
        public ActionResult Artist(string artistName)
        {
            return View(Index(artistName));
        }
    }
}
