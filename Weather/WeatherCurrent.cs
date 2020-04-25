namespace Weather
{
    public class WeatherCurrent : WeatherObject
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string TimeZone { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public double Temp { get; set; }
        public double Feels_Like { get; set; }
        public double UVI { get; set; }
        public int Visibility { get; set; }
    }
}