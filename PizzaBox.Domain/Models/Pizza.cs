using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace PizzaBox.Domain
{
    public class Pizza
    {
      public int PizzaId {get; set;}
      public int CrustId {get; set;}
      public int SizeId {get; set;}      
      public int OrderId {get; set;}
      //public int ToppingsOrderId {get; set;}
      public decimal PizzaCost {get; set;}
      
      //----unstored-----
      [NotMapped]
      public int toppingsMax =5;
      

    }
}
