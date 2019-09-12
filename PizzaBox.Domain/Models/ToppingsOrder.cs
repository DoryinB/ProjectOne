using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
    public class ToppingsOrder
    {
      public int ToppingsOrderId {get; set;}
      public int PizzaId {get; set;}
      public int ToppingId {get; set;}
          
    }
}
