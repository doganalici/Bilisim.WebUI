using Bilisim.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bilisim.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           // string mesaj = "MVC web programlamaya hoş geldiniz.";
            return View("MyView");
        }

        //public string Index()
        //{
        //    string mesaj = "MVC web programlamaya hoş geldiniz.";
        //    return mesaj;
        //}

        //public string[] Index()
        //{
        //    string[] isimler = { "Adem AKKUŞ", "Doğan ALICI", "Mehmet ÖZHAN", "Veciye CEYHAN", "Umut B. TER", "Zehra ÖZTÜRK" };
        //    return isimler;
        //}

        //public bool Index()
        //{
        //    return (3<5);
        //}
    }
}
