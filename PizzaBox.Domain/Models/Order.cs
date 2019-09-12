using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain
{
    public class Order
    {
      public int OrderId {get; set;}
      public int LocationId {get; set;}
      public decimal OrderCost {get; set;}
      //-----unstored-----
      [NotMapped]
      public decimal OrderCostMax = 5000m;
      [NotMapped]
      public int PizzaNumber {get; set;}
      [NotMapped]
      public int PizzaNumberMax = 100;
    

    }
}
