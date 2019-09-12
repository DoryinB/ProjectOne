using System;
using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
    public class Crust
    {
      public int CrustId {get; set;}
      [Required(ErrorMessage="Please a crust name is needed for processing")]
      public string CrustName {get; set;}
      public decimal CrustCost {get; set;}


    }
}
