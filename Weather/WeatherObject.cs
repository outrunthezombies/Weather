using System;

namespace Weather
{
    public class WeatherObject
    {
        public long Date { get; set; }
        public int Pressure { get; set; }
        public int Humidity { get; set; }
        public double Dew_Point { get; set; }
        public double Wind_Speed { get; set; }
        public double Wind_Deg { get; set; }
        public int Clouds { get; set; }
        public int ID { get; set; }
        public string Main { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}