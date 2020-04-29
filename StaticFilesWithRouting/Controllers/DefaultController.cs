using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticFilesWithRouting.Controllers
{
    public class DefaultController: Controller
    {

        // commenting following will make static files work
        [HttpGet("{*all}", Order = int.MaxValue)]
        public IActionResult DefaultRoute()
        {
            return Content("Its me always !!! Static files are not working");
        }

    }


}
