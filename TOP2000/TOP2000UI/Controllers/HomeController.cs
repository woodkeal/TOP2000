using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using TOP2000UI.Models;
using TOP2000UI.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace TOP2000UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private IConfiguration Configuration;

        public HomeController(IConfiguration _configuration)
        {
            Configuration = _configuration;
        }

        public IActionResult Index(string artistOrTitleName)
        {
            string whereString;
            string connString = this.Configuration.GetConnectionString("DefaultConnection");
            List<Top2000ViewModel> top2000VMList = new List<Top2000ViewModel>();
            TOP2000Context top2000db = new TOP2000Context();
            
            //uses connetion once before ending all connections
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (artistOrTitleName != null) {
                    whereString = $"WHERE Tp.Jaar = 2019 AND So.Titel LIKE '%{artistOrTitleName}%' OR Tp.Jaar = 2019 AND AR.Naam LIKE '%{artistOrTitleName}%'";
                } else {
                    whereString = "WHERE Tp.Jaar = 2019";
                }
                //retrieve the SQL Server instance version
                var top2000query =
                $@"
                SELECT 
                Li.positie, 
                ISNULL((CONVERT(varchar(10),(SELECT L.positie FROM Lijst AS L
		            WHERE L.top2000Jaar = Li.top2000Jaar - 1
		            AND L.songid = Li.songid
		            ) - Li.positie)), 'Nieuw' )AS [verschil],
                So.Titel,
                Ar.Naam,
                So.Jaar,
                Tp.Jaar
 
                FROM Top2000Jaar as Tp

                INNER JOIN Lijst AS Li ON
                Li.Top2000Jaar = Tp.Jaar

                INNER JOIN Song AS So ON
                So.songid = Li.songid

                INNER JOIN Artiest AS Ar ON
                Ar.Artiestid = So.artiestid
                   
                {whereString}
                 ";
                //define the SqlCommand object
                SqlCommand cmd = new SqlCommand(top2000query, conn);

                //open connection
                conn.Open();

                //execute the SQLCommand
                SqlDataReader dr = cmd.ExecuteReader();

                Console.WriteLine(Environment.NewLine + "Retrieving data from database..." + Environment.NewLine);
                Console.WriteLine("Retrieved records:");

                

                //check if there are records
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Top2000ViewModel objcvm = new Top2000ViewModel();
                        objcvm.Position = dr.GetInt32(0);
                        objcvm.Difference = dr.GetString(1);
                        objcvm.Title = dr.GetString(2);
                        objcvm.ArtistName = dr.GetString(3);
                        objcvm.Year = dr.GetInt32(4);
                        objcvm.ListYear = dr.GetInt32(5);

                        top2000VMList.Add(objcvm);
                    }
                }
                else
                {
                    Console.WriteLine("No data found.");
                }

                //close data reader
                dr.Close();

                //close connection
                conn.Close();
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

        //gets inpute from view
        [HttpPost]
        public ActionResult Artist(string artistOrTitleName)
        {
            return View(Index(artistOrTitleName));
        }

    }
}