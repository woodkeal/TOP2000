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
            var dbContext = new TOP2000Context();
            List<spTop10ListingOnYear> top10listingOnYearList = new List<spTop10ListingOnYear>();

            if (listYear != 0)
            {
                top10listingOnYearList = dbContext.spTop10ListingOnYear.FromSqlRaw($"spTop10ListingOnYear {listYear}").ToList();
            }
            else
            {
                top10listingOnYearList = dbContext.spTop10ListingOnYear.FromSqlRaw($"spTop10ListingOnYear 2019").ToList();
            }

            return View(top10listingOnYearList);
        }
        [HttpPost]
        public ActionResult YearList(string listYear)
        {
            int yearlist = Convert.ToInt32(listYear);
            return View(Index(yearlist));
        }
    }
}
