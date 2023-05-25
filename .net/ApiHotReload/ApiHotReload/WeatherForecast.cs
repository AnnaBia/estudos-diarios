// classe responsável por denominar as propriedades usadas para previsão do tempo

namespace ApiHotReload
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556); // ocorre a conversão da temperatura em Celsius para fahrenheit

        public string? Summary { get; set; }
    }
}
