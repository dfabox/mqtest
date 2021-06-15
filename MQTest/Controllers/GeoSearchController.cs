using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MQTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GeoSearchController : ControllerBase
    {
        private readonly ILogger<GeoSearchController> _logger;

        public GeoSearchController(ILogger<GeoSearchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("~/ip/location")]
        public string GetIpLocation(string ip)
        {
            return null;
        }

        [HttpGet]
        [Route("~/city/locations")]
        public string GetCityLocation(string city)
        {
            return null;
        }
    }
}
