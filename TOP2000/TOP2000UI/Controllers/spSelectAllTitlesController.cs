using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;

namespace TOP2000UI.Controllers
{
    public class spSelectAllTitlesController : Controller
    {
        public IActionResult Index()
        {
            var dbContext = new TOP2000Context();
            var allTitles = dbContext.spSelectAllTitles.FromSqlRaw($"spSelectAllTitles").ToList();
            return View(allTitles);
        }
    }
}
