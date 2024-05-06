using METROAPI;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
namespace METROAPI.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private static List<Order> _OrderDetails=new List<Order>()
        {
           new Order{OrderID=1,FromLocation="annanagar",ToLocation="chepauk",TicketPrice=100,Date="2000-09-09"},
             new Order{OrderID=1,FromLocation="annanagar",ToLocation="chepauk",TicketPrice=100,Date="2000-09-09"}
        };
         [HttpGet]
        public IActionResult GetTicket()
        {
            return Ok(_OrderDetails);
        }
        [HttpGet("{id}")]
        public IActionResult PutTicket(int id)
        {
             var OrderDetails=_OrderDetails.FindIndex(T=>T.OrderID==id);
            if(_OrderDetails==null)
            {
                return NotFound();
            }
            return Ok(_OrderDetails);
        }
        [HttpPost]
        public IActionResult PostTicket([FromBody]Order OrderDetails)
        {
            _OrderDetails.Add(OrderDetails);
            return Ok();
        }
         [HttpPut("{id}")]
        public IActionResult PutMedicine(int id,[FromBody] Order OrderDetails)
        {
            var index=_OrderDetails.FindIndex(O=>O.OrderID==id);
            if(index<0)
            {
                return NotFound();
            }
            _OrderDetails[index]=OrderDetails;
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var DeleteOrder=_OrderDetails.Find(O=>O.OrderID==id);
            if(DeleteOrder==null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}