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
                from Song in top2000db.Songs
                join Artiests in top2000db.Artiests on Song.Artiestid equals Artiests.Artiestid
                select new { Song.Songid, Song.Titel, Song.Jaar, Artiests.Naam }).ToList();
            foreach (var item in top2000list)
            {
                Top2000ViewModel objcvm = new Top2000ViewModel();
                objcvm.Title = item.Titel;
                objcvm.Jaar = item.Jaar;
                objcvm.ArtiestNaam = item.Naam;
                objcvm.songid = item.Songid;
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
