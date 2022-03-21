using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.ex02_MVC.Controllers
{
    public class HomeController : Controller
    {
        
        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день" + ", " + hel;
            return Greeting;
        }
        
    }
}