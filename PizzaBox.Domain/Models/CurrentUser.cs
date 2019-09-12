using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain
{
  [NotMapped]
    public class CurrentUser
    {
      [NotMapped]      
      public static int UserId {get; set;}
      [NotMapped]
      public static int UserHistoryId {get; set;}
      [NotMapped]
      public static int OrderId {get; set;}
      [NotMapped]
      public static int LocationId {get; set;}
      [NotMapped]
      public static int PizzaIndexId {get; set;}
      [NotMapped]
      public static Pizza Pizza = new Pizza();
      
    }
}
