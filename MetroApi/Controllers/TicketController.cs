using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//using OnlineMedicalStore.Data; 

namespace METROAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController:ControllerBase
    {
        private readonly ApplicationDBContext _dbContext;
        public TicketController(ApplicationDBContext applicationDBContext)
        {
            _dbContext = applicationDBContext;
        }
        /*
        private static List<Ticket> _TicketDetails=new List<Ticket>()
        {
            new Ticket{TicketID=1,FromLocation="annanagar",ToLocation="chepauk",TicketPrice=50},
             new Ticket{TicketID=1,FromLocation="annanagar",ToLocation="chepauk",TicketPrice=50}
        };*/
        [HttpGet]
        public IActionResult GetTicket()
        {
            return Ok(_TicketDetails);
        }
        [HttpGet("{id}")]
        public IActionResult PutTicket(int id)
        {
             var TicketDetails=_TicketDetails.FindIndex(T=>T.TicketID==id);
            if(_TicketDetails==null)
            {
                return NotFound();
            }
            return Ok(_TicketDetails);
        }
        [HttpPost]
        public IActionResult PostTicket([FromBody]Ticket TicketDetails)
        {
            _TicketDetails.Add(TicketDetails);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult PutMedicine(int id,[FromBody] Ticket TicketDetails)
        {
            var index=_TicketDetails.FindIndex(T=>T.TicketID==id);
            if(index<0)
            {
                return NotFound();
            }
            _TicketDetails[index]=TicketDetails;
            return Ok();
        }
          [HttpDelete("{id}")]
          public IActionResult DeleteTicket(int id)
          {
            var DeleteTicket=_TicketDetails.Find(T=>T.TicketID==id);
            if(DeleteTicket==null)
            {
                return NotFound();
            }
            return Ok();
          }
    }
}