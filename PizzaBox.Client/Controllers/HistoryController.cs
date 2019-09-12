using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Data;
using PizzaBox.Domain;
using PizzaBox.Domain.Models;

namespace PizzaBox.Client.Controllers
{
    public class HistoryController : Controller
    {
        private PizzaBoxDbContext _db = new PizzaBoxDbContext();
        public IActionResult Index()
        {
          foreach (var h in _db.History.ToList())
           if(h.UserId==CurrentUser.UserId)
             {return View(h);}
             return RedirectToAction("Error");
        }

        public IActionResult Error()
        {
          return View();
        }

    }
}
