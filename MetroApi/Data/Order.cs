//using system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace METROAPI.Controllers;
  [Table("", Schema = "public")]
public class Order
{
    [Key]
    public int OrderID { get; set; }
    
    public string FromLocation { get; set; }
    
    public string ToLocation { get; set; }
    public int TicketPrice { get; set; }
    
      public string Date { get; set; }
      
}
