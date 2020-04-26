namespace Weather
{
    public class WeatherDaily : WeatherObject
    {
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public double Rain { get; set; }
        public double UVI { get; set; }
        public double Temp_Day { get; set; }
        public double Temp_Night { get; set; }
        public double Temp_Eve { get; set; }
        public double Temp_Morn { get; set; }
        public double Temp_Day_Min { get; set; }
        public double Temp_Day_Max { get; set; }
        public double Feels_Like_Day { get; set; }
        public double Feels_Like_Night { get; set; }
        public double Feels_Like_Eve { get; set; }
        public double Feels_Like_Morn { get; set; }
    }
}