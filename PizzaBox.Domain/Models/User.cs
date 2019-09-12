using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain
{
    public class User
    {
      public int UserId {get; set;}
      public string HistoryId {get; set;}
      
      public int HistoryIntId {get; set;}

      [Required(ErrorMessage="Please a crust name is needed for processing")]
      
      public string Username {get; set;}
      // public string Password {get; set;}
      
    }
}
