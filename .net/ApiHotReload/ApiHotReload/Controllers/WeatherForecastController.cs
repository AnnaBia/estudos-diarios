using Microsoft.AspNetCore.Mvc;

namespace ApiHotReload.Controllers
{
    [ApiController]
    [Route("[controller]")]
    // rota do controlador denominada WeatherForecastController
    public class WeatherForecastController : ControllerBase
    {
        // array de string estatico
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
        // instância da classe logger, cuja a responsabilidade é escrever uma mensagem de log
        private readonly ILogger<WeatherForecastController> _logger;
        
        // injetando a instância no construtor do controlador
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            // gera uma sequência de números num intervalo de 1 - 5
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                /*
                    esses número serão incluídos na data(index)
                    que vai gerar a previsão do tempo para 5 datas distintas
                    e serão retornadas para a api
                */
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }) 
            .ToArray();
        }

        // método get teste
        [HttpGet("HotReloadTest")]
        public IEnumerable<string> GetTesteHotReload()
        {
            // retorna um array de informações
            return new string[] { "Hot Reload", "Visual Studio 2022", ".NET 6" };
        }
    }
}