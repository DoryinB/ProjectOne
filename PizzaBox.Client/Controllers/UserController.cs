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
    public class UserController : Controller
    {
        private PizzaBoxDbContext _db = new PizzaBoxDbContext();
        
        public IActionResult Login()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Login(User u)
        {
            foreach (var db in _db.User.ToList())
          {
            if(u.Username==db.Username)
            {
              CurrentUser.UserId=db.UserId;
              return RedirectToAction("UserMenu");
              //return UserMenu(u);
            }
          }          
            return RedirectToAction("Fail");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User u)
        {
          
            foreach (var db in _db.User.ToList())
          {

            if(u.Username==db.Username)
            {
              return RedirectToAction("Fail");
            }
          }

          _db.User.Add(u);
          _db.SaveChanges();        

            return RedirectToAction("Login");
            
        }

        public IActionResult DisplayUsers()
        {
          return View(_db.User.ToList());
        }

        public IActionResult Fail()
        {
          return View();
        }

        public IActionResult Success()
        {
          return View();
        }

        public IActionResult UserMenu()
        {
          foreach (var u in _db.User.ToList())
          {
            if(u.UserId==CurrentUser.UserId)
            {
              return View(u);}
          }
          return RedirectToAction("login");
        }
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
