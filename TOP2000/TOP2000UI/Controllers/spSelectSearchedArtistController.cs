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
            string spInputText;
            var dbContext = new TOP2000Context();
            List<spSelectSearchedArtist> searchedArtist = new List<spSelectSearchedArtist>();

            //checks if there is a artist name passed on else put a "ABBA" instead
            if (artistName != null)
            {
                spInputText = $"spSelectSearchedArtist {artistName}";
                
            } else
            {
                spInputText = $"spSelectSearchedArtist ABBA";
            }

            //calls stored procedure and put it in a list
            searchedArtist = dbContext.spSelectSearchedArtist.FromSqlRaw(spInputText).ToList();

            return View(searchedArtist);
        }

        //gets inpute from view
        [HttpPost]
        public ActionResult Artist(string artistName)
        {
            return View(Index(artistName));
        }
    }
}
