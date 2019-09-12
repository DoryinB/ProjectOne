using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Client.Models;
using PizzaBox.Data;
using PizzaBox.Domain;

namespace PizzaBox.Client.Controllers
{
    public class OrderController : Controller
    {
        private PizzaBoxDbContext _db = new PizzaBoxDbContext();
        Order o = new Order();
        public IActionResult Index()
        {
          
          //--------------
          var uni = _db.Pizza.Include("PizzaIndex").Include("").ToList();

          // var q = from c in _db.Pizza.ToList().Union(_db.PizzaIndex).ToList()
          // where c.PizzaId == PizzaIndex.PizzaIndexId
          // select c;
          // return _db.Pizza.Include("CustomerAddress").ToList();
          
          // foreach(var p in uni)
          // {
          //   if (p.==CurrentUser.OrderId)
          //   {
              
          //   }

          // }

            return View(_db.Pizza.Include("PizzaIndex").Include("").ToList());
        }


        public IActionResult Fail()
        {
          return View();
        }

        public IActionResult Success()
        {
          return View();
        }

        public IActionResult Location()
        { 
           return View();
        }

        [HttpPost]
        public IActionResult Location(Order o)
        {
          CurrentUser.LocationId=o.LocationId;
          CurrentUser.OrderId=o.OrderId;
          System.Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n"+CurrentUser.LocationId+"\n\n\n\n\n\n\n\n\n\n\n");
          _db.Order.Add(o);
          _db.SaveChanges();
          CurrentUser.OrderId=o.OrderId;

            return RedirectToAction("DisplayLocation");
            //return Order(location);
        }
        public IActionResult DisplayLocation()
        {
          
          foreach (var id in _db.Location.ToList())
          {
            if(CurrentUser.LocationId==id.LocationId)
              {return View(id);}
          }
          return View();
        }

        public IActionResult CreatePizza()
        {
            return View();
        }
        public IActionResult RemovePizza()
        {
            return View();
        }

        public IActionResult SaveOrder()
        {



          // _db.Order.Add();
          // _db.SaveChanges();
           return View();
        }

        public IActionResult PartialLocation()
        {
          return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


//-----------
//               public static List<Pizza> Instance()
//               {
//                 var q = from c in _db.Pizza
//                         where c.PizzaId == _db.PizzaIndex.PizzaIndexId
//                         select c;
//                 return db.Customer.Include("CustomerAddress").ToList();

                
//               }

//               public static List<var> Instance1()
//               {
//                 return _db.PizzaIndex.Include("Pizza").ToList();
//               }
// 
// //-----------


    }
}
