///using Microsoft.AspNetCore.Mvc;
///using BookStoreApi.BobSpace;
///using MongoDB.Bson.Serialization.Conventions;

///namespace BookStoreApi.Controllers
///{
    ///[ApiController]
    ///[Route("[controller]")]
    ///public class WeatherForecastController : ControllerBase
    ///{
        ///public void doStuff()
        ///{

            ///var bob = new Human();


        ///}

        ///private static readonly string[] Summaries = new[]
        ///{
        ///"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ///};

        ///private readonly ILogger<WeatherForecastController> _logger;

        ///public WeatherForecastController(ILogger<WeatherForecastController> logger)
        ///{
            ///_logger = logger;
        ///}

        ///[HttpGet(Name = "GetWeatherForecast")]
        ///public IEnumerable<WeatherForecast> Get()
       /// {
            ///return Enumerable.Range(1, 5).Select(index => new WeatherForecast
           /// {
                ///Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
               /// TemperatureC = Random.Shared.Next(-20, 55),
                ///Summary = Summaries[Random.Shared.Next(Summaries.Length)]
          ///  })
            ///.ToArray();
        ///}
   /// }
///}