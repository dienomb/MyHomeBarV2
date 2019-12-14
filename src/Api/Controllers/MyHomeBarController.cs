using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyHomeBarV2.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class MyHomeBarController : ControllerBase
    {
        private readonly ILogger _logger;

        public MyHomeBarController(ILogger<MyHomeBarController> logger)
        {
            _logger = logger;
        }

        private void test()
        {
            _logger.DrinkAdded("Vodka");
        }
    }
}
