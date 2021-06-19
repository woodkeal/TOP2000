//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TOP2000UI.Models;
//using TOP2000UI.ViewModels;

//namespace TOP2000UI.Controllers
//{
//    public class SongsArtistDetailsController : Controller
//    {
//        public ActionResult Index()
//        {
//            TOP2000Context top2000db = new TOP2000Context();
//            List<Top2000ViewModel> top2000VMList = new List<Top2000ViewModel>();
//            var top2000list = (
//                from Song in top2000db.Songs
//                join Artiests in top2000db.Artiests on Song.Artiestid equals Artiests.Artiestid
//                select new { Song.Songid, Song.Titel, Song.Jaar, Artiests.Naam }).ToList();
//            foreach (var item in top2000list)
//            {
//                Top2000ViewModel objcvm = new Top2000ViewModel();
//                objcvm.Title = item.Titel;
//                objcvm.Jaar = item.Jaar;
//                objcvm.ArtiestNaam = item.Naam;
//                objcvm.songid = item.Songid;
//                top2000VMList.Add(objcvm);
//            }

//            return View(top2000VMList);
//        }
//    }
//}
