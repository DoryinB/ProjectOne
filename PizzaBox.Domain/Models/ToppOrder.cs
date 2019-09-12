using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaBox.Domain.Models
{
  [NotMapped]
  public class ToppOrder
  {
    [NotMapped]
        //public  List<ToppingsOrder> TOp {get; set;}
        public List<int> TOp {get; set;}
  }
}