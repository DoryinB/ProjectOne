using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
    public class History
    {
      public int HistoryId {get; set;}
      public int UserId {get; set;}
      public int OrderId {get; set;}

    }
}
