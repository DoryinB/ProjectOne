using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;
using PizzaBox.Data;
using PizzaBox.Domain;

namespace PizzaBox.Client.Controllers
{
    public class StoreController : Controller
    {
        private PizzaBoxDbContext _db = new PizzaBoxDbContext();
        
        public IActionResult Index()
        {
          return View();
        }
        public IActionResult Login()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Login(Store s)
        {
            foreach (var db in _db.Location.ToList())
          {
            if(s.StoreId==db.LocationId)
            {
              CurrentUser.LocationId=s.StoreId;
              return RedirectToAction("Index");
            }
          }          
            return RedirectToAction("Fail");
        }

        
        public IActionResult StoreOrders()
        {
          return View(CurrentUser.LocationId);
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
