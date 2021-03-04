using System;

namespace CalculatorAPI
{
    public class JsonResponse
    {
        public string message { get; set; }
        public JsonResponse(string message)
        {
            this.message = message;
        }
    }
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }
    }
    public class CalculatorModel
    {
        public float addition { get; set; }
        public float Add(float x, float y)
        {
            return x + y;
        }
        public CalculatorModel(float addition)
        {
            this.addition = addition;
        }
    }
}
