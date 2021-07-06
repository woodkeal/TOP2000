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
        public IActionResult Index(string listYear)
        {
            string spInputText;
            var dbContext = new TOP2000Context();
            List<spSelectListingOnYear> listingOnYearList = new List<spSelectListingOnYear>();

            //checks if there is a artist name passed on else put "2019" instead
            if (listYear != null)
            {
                spInputText = $"spSelectListingOnYear {listYear}";
            }
            else
            {
                spInputText = $"spSelectListingOnYear 2019";
            }

            //calls stored procedure and put it in a list
            listingOnYearList = dbContext.spSelectListingOnYear.FromSqlRaw(spInputText).ToList();

            return View(listingOnYearList);
        }

        //gets inpute from view
        [HttpPost]
        public ActionResult YearList(string listYear)
        {
            return View(Index(listYear));
        }
    }
}

