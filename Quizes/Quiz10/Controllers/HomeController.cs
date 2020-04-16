using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz10.Models;

namespace Quiz10.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Human AJ = new Human
            {
                Name = "AJ",
                Age = 28,
                Job = "Marine",
                FavColor = "Purple",
                Hobby = "3D Modeling"
            };
            return View(AJ);
        }
    }
}