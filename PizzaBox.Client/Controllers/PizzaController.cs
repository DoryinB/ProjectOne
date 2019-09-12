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
    public class PizzaController : Controller
    {
        private PizzaBoxDbContext _db = new PizzaBoxDbContext();
        private int Cost =0;
        private Pizza nowPizza = new Pizza();

        public IActionResult Index()
        {
           return View();
        }

        public IActionResult Size()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Size(Size size)
        {
          nowPizza.OrderId=CurrentUser.OrderId;
          CurrentUser.Pizza.SizeId=size.SizeId;
          nowPizza.SizeId=size.SizeId;
          CurrentUser.Pizza.PizzaCost=CurrentUser.Pizza.PizzaCost+size.SizeCost;
          nowPizza.PizzaCost=nowPizza.PizzaCost+size.SizeCost;
          return RedirectToAction("Crust");
        }

        public IActionResult Crust()
        {
          return View();
        }

        [HttpPost]
        public IActionResult Crust(Crust crust)
        {
          CurrentUser.Pizza.CrustId=crust.CrustId;
          nowPizza.CrustId=crust.CrustId;
          CurrentUser.Pizza.PizzaCost=CurrentUser.Pizza.PizzaCost+crust.CrustCost;
          nowPizza.PizzaCost=nowPizza.PizzaCost+crust.CrustCost;
          //-------------------------------------------------------------
          nowPizza.CrustId=CurrentUser.Pizza.CrustId;
          nowPizza.OrderId=CurrentUser.OrderId;
          nowPizza.PizzaCost=CurrentUser.Pizza.PizzaCost;
          nowPizza.SizeId=CurrentUser.Pizza.SizeId;
          _db.Pizza.Add(nowPizza);
          _db.SaveChanges();
          //-------------------------------------------------------------
          History h = new History();
          h.UserId=CurrentUser.UserId;
          h.OrderId=CurrentUser.OrderId;
          _db.History.Add(h);
          _db.SaveChanges();
          //-------------------------------------------------------------
          foreach (var p in _db.Pizza.ToList())
          {
            if(p.OrderId==CurrentUser.OrderId)
            {
              if(p.PizzaId>CurrentUser.Pizza.PizzaId)
              {CurrentUser.Pizza.PizzaId=p.PizzaId;}
            }
          }
          System.Console.WriteLine("\n\n\n\ncurrentPizzaId"+CurrentUser.Pizza.PizzaId+"\n\n\n\n\n");
          //nowPizza.PizzaId=CurrentUser.Pizza.PizzaId;
          //-------------------------------------------------------------
          return RedirectToAction("Topping");
        }

        public IActionResult Topping()
        {
          
          return View();
        }

        [HttpPost]
        public IActionResult Topping(ToppOrder user)
        {
          System.Console.WriteLine("\n\n\n\n\n\nB");  
          foreach (var tO in user.TOp)
          {
            ToppingsOrder t = new ToppingsOrder();
            t.ToppingId=tO;
            t.PizzaId=CurrentUser.Pizza.PizzaId;
            System.Console.WriteLine(t.ToppingId);
            _db.ToppingsOrder.Add(t);
            _db.SaveChanges();
          }
          System.Console.WriteLine("E\n\n\n\n\n\n");

          foreach (var to in _db.ToppingsOrder.ToList())
          {
            foreach (var t in _db.Topping)
            {
              if (to.ToppingId==t.ToppingId)
              {
                CurrentUser.Pizza.PizzaCost=CurrentUser.Pizza.PizzaCost+t.ToppingsCost;
              }
            }
          }
          return RedirectToAction("DisplayPizza");
        }

        public IActionResult DisplayPizza()
        {
          
          List<int> ids = new List<int>{};
          List<Pizza> pizzas = new List<Pizza>{};

          foreach (var o in _db.Order)
          {
            if (CurrentUser.OrderId==o.OrderId)
            {return View(o);}
          }
          
          return View();
          //return View(pizzas);
        }
    
        public IActionResult Fail()
        {
          return View();
        }

        public IActionResult Success()
        {
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
