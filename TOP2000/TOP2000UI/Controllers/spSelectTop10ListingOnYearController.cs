using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spSelectTop10ListingOnYearController : Controller
    {
        public IActionResult Index(int listYear)
        {
            string spInputText;
            var dbContext = new TOP2000Context();
            List<spTop10ListingOnYear> top10listingOnYearList = new List<spTop10ListingOnYear>();

            //checks if there is a artist name passed on else put a "ABBA" instead
            if (listYear != 0)
            {
                spInputText = $"spTop10ListingOnYear {listYear}";
            }
            else
            {
                spInputText = $"spTop10ListingOnYear 2019";   
            }

            //calls stored procedure and put it in a list
            top10listingOnYearList = dbContext.spTop10ListingOnYear.FromSqlRaw(spInputText).ToList();

            return View(top10listingOnYearList);
        }

        //gets inpute from view
        [HttpPost]
        public ActionResult YearList(string listYear)
        {
            int yearlist = Convert.ToInt32(listYear);
            return View(Index(yearlist));
        }
    }
}
