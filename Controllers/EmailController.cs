using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ImmersionApi.Controllers
{
    [Route("api/[controller]")]
    public class EmailController: ControllerBase{
        [AcceptVerbs("Get")]
        [Route("item")]
        public IActionResult GetItem(string item){
            return Ok(item);
        }
    }
    
}