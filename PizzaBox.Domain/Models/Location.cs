using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
    public class Location
    {
      public int LocationId {get; set;}
      [Required(ErrorMessage="Please a crust name is needed for processing")]

      public int StoreId {get; set;}

      public string LocationName {get; set;}
      
    }
}
