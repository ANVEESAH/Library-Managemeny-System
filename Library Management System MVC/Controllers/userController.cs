﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library_Management_System_MVC.Controllers
{
    public class userController : Controller
    {
        // GET: user
        public ActionResult Index(string email)
        {
            return View();
        }
    }
}