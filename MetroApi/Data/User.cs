
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace METROAPI;
 [Table("userInfo", Schema = "public")]
public class User
{
    [Key]
    
    public int UserID { get; set; }
    public string UserName { get; set; }
    
    public string UserEmail{ get; set; }
    public double UserBalance { get; set; }
    public string UserPhone { get; set; }
    public string UserPassword { get; set; }
    
}