using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Program
{
    public class Weather
    {
        public Temp Main { get; set; }
    }

    public class Temp
    {
        public double temp { get; set; }
    }
    
    static async Task Main(string[] args)
    {
        string Url = $"https://api.openweathermap.org/data/2.5/weather?lat=56.4977&lon=84.9744&appid=f8d845c3f2c6a227da9a1a1c078ed382";
        using var Client = new HttpClient();
        var GettingDataFromTheSite = await Client.GetAsync(Url);
        string ReadingData = await GettingDataFromTheSite.Content.ReadAsStringAsync();
        Weather ConvertedData = JsonConvert.DeserializeObject<Weather>(ReadingData);
        Console.WriteLine($"Температура в Томске: {1.8 * (ConvertedData.Main.temp - 273)} °C");
    }
}

