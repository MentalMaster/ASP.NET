using Lab01.ex02_MVC.Models;
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
            string Greeting = ModelClass.ModelHello() + ", " + hel; 
            return Greeting;
        }

    }
}