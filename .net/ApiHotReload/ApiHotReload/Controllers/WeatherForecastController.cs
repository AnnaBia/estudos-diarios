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
        // inst�ncia da classe logger, cuja a responsabilidade � escrever uma mensagem de log
        private readonly ILogger<WeatherForecastController> _logger;
        
        // injetando a inst�ncia no construtor do controlador
        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            // gera uma sequ�ncia de n�meros num intervalo de 1 - 5
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                /*
                    esses n�mero ser�o inclu�dos na data(index)
                    que vai gerar a previs�o do tempo para 5 datas distintas
                    e ser�o retornadas para a api
                */
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }) 
            .ToArray();
        }

        // m�todo get teste
        [HttpGet("HotReloadTest")]
        public IEnumerable<string> GetTesteHotReload()
        {
            // retorna um array de informa��es
            return new string[] { "Hot Reload", "Visual Studio 2022", ".NET 6" };
        }
    }
}