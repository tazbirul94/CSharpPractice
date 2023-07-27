using Demo.WebApi.Models;
using Demo.WebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IProductService<Product> _product;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IProductService<Product> product)
        {
            _logger = logger;
            _product = product;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public Task<Product> Get()
        {
            return _product.GetProductById(1);
        }
    }
}