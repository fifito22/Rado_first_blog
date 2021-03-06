﻿using rado_blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rado_blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new ApplicationDbContext();
            var posts = db.Posts.OrderByDescending(p => p.Date).Take(3);
            return View(posts.ToList());
        }


    }
}