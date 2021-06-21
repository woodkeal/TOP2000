using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TOP2000UI.Models;
using TOP2000UI.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace TOP2000UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            TOP2000Context top2000db = new TOP2000Context();
            List<Top2000ViewModel> top2000VMList = new List<Top2000ViewModel>();
            var top2000list = (
                from Top2000Jaar in top2000db.Top2000Jaar
                join Lijst in top2000db.Lists on Top2000Jaar.Jaar equals Lijst.Top2000jaar
                join Songs in top2000db.Songs on Lijst.Songid equals Songs.Songid
                join Artiests in top2000db.Artists on Songs.Artiestid equals Artiests.Artiestid
                where Top2000Jaar.Jaar == Convert.ToInt32((DateTime.Now.Year - 2))
                orderby Lijst.Positie ascending
                select new {  Lijst.Positie, Songs.Titel, Artiests.Naam, Songs.Jaar, ListYear = Top2000Jaar.Jaar }).ToList();
            foreach (var item in top2000list)
            {
                Top2000ViewModel objcvm = new Top2000ViewModel();
                objcvm.Position = item.Positie;
                objcvm.Title = item.Titel;
                objcvm.ArtistName = item.Naam;
                objcvm.Year = item.Jaar;
                objcvm.ListYear = item.ListYear;

                top2000VMList.Add(objcvm);
            }

            return View(top2000VMList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }



    }
}
