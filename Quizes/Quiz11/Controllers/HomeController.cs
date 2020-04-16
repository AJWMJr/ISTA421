using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Quiz11.Models;

namespace Quiz11.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            HumanRepository repo = new HumanRepository();
            return View(repo);
        }
    }
}