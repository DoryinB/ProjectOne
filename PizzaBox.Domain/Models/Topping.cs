using System.ComponentModel.DataAnnotations;

namespace PizzaBox.Domain
{
  public class Topping
    {
      public int ToppingId {get; set;}
      [Required(ErrorMessage="Please a crust name is needed for processing")]
      public string ToppingsName {get; set;}
      public decimal ToppingsCost {get; set;}
    }
}
