using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TesteCoffe.Models;

namespace TesteCoffe.Controllers
{
    public class HomeController : Controller
    {
  

        public IActionResult Index()
        {
           
            return View();
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




        public IActionResult About()
        {
            return View();
        }


        public IActionResult Tattoos()
        {
            return View();
        }

        public IActionResult Loja()
        {
            return View();
        }



        public IActionResult Produtos()
        {
            return View();
        }


    }
}