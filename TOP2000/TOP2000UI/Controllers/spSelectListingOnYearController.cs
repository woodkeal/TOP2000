using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spSelectListingOnYearController : Controller
    {
        public IActionResult Index(int listYear)
        {
            var dbContext = new TOP2000Context();
            List<spSelectListingOnYear> listingOnYearList = new List<spSelectListingOnYear>();

            listingOnYearList = dbContext.spSelectListingOnYear.FromSqlRaw($"spSelectListingOnYear {listYear}").ToList();
         
          

            return View(listingOnYearList);
        }

        [HttpPost]
        public ActionResult YearList(string listYear)
        {
        
            int yearlist = Convert.ToInt32(listYear);
            return View(Index(yearlist));
        }
    }
}

