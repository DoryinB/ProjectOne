using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
    public class Size
    {
      public int SizeId {get; set;}
      [Required(ErrorMessage="Please a crust name is needed for processing")]
      public string SizeName {get; set;}
      public decimal SizeCost {get; set;}


    }
}
