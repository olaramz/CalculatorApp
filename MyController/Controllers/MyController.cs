using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyLogic;
using MyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyController.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly ILogic _logic;
        public MyController (ILogic logic)
        {
            _logic = logic;
        }
        
        [HttpPost]
        public IActionResult Area1 (RectangleViewModel model)
        {
            var giveme = _logic.Area1(model);
            return Ok(giveme);
        }

        [HttpPost]
        public IActionResult Area2(TriangleViewModel model)
        {
            var give = _logic.Area2(model);
            return Ok(give);
        }
    }


}
