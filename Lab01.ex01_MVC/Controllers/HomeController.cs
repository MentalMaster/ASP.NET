﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab01.ex01_MVC.Controllers
{
    public class MyController : Controller
    {
        
        public string Start() 
        { 
            int hour = DateTime.Now.Hour; 
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день"; 
            return Greeting; 
        }
    }
}