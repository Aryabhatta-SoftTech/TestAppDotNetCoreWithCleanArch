using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Core.Models;
using TestApp.Domain.Students;

namespace TestApp.Controllers
{
    [ApiController]
    //[Route("[controller]/api")] //this will give an URL: http://localhost:11098/weatherforecast/api/{{METHODNAME}}
    //[Route("[controller]/RAJA")] //this will give an URL: http://localhost:11098/weatherforecast/RAJA/{{METHODNAME}}
    [Route("[controller]")] //this will give an URL: http://localhost:11098/weatherforecast/{{METHODNAME}}
    /*
     Weatherforecast: is a controller name without "Controller" keyword
    */
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStudentsDashboard _iStudentDashboard;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStudentsDashboard studentsDashboard)
        {
            _logger = logger;
            _iStudentDashboard = studentsDashboard;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public int Post()
        {
            var rng = new Random();
            return 1;
        }

        [Route("GetDataFromGetMethod")]
        [HttpGet]
        public IEnumerable<StudentDashboardModel> GetDataFromGetMethod()
        {
            return _iStudentDashboard.GetStudentData();
        }
    }
}
