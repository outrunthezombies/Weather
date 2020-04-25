using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Weather;

public static class SharedCode
{
    private static readonly string APPID = "e2a6fd9fa5221cdb191800358b8c1376";
    private static readonly string WeatherAPI = "/data/2.5/onecall";
    private static readonly string WeatherAPIURL = "http://api.openweathermap.org";
    private static double latitude = 43.658220;
    private static double longitude = -79.478610;
    private static readonly string JSONURL = WeatherAPIURL + WeatherAPI + "?appid=" + APPID + "&lat=" + latitude + "&lon=" + longitude;
    private static string JSONRawData;
    public static WeatherCurrent weather = new WeatherCurrent();
    public static List<WeatherHourly> weatherHourlyItems = new List<WeatherHourly>();
    public static List<WeatherDaily> weatherDailyItems = new List<WeatherDaily>();
    public static List<JToken> GetJProperties(List<JToken> items)
    {
        return items;
    }
    public static string DateAsString(long value)
    {
        return new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(value).Subtract(TimeSpan.FromHours(4)).ToString("MMMM dd, yyyy h:mm:ss tt");
    }
    public static void ParseSharedValues(WeatherObject weather, JProperty item)
    {
        switch (item.Name)
        {
            case "dt":
                weather.Date = (long)item.Value;
                break;
            case "pressure":
                weather.Pressure = (int)item.Value;
                break;
            case "humidity":
                weather.Humidity = (int)item.Value;
                break;
            case "dew_point":
                weather.Dew_Point = (double)item.Value;
                break;
            case "wind_speed":
                weather.Wind_Speed = (double)item.Value;
                break;
            case "wind_deg":
                weather.Wind_Deg = (int)item.Value;
                break;
            case "clouds":
                weather.Clouds = (int)item.Value;
                break;
            case "weather":
                List<JToken> weatherDetails = item.Children().Children().ToList();
                foreach (JToken weatherDetail in weatherDetails)
                {
                    foreach (JProperty detail in weatherDetail)
                    {
                        switch (detail.Name)
                        {
                            case "id":
                                weather.ID = (int)detail.Value;
                                break;
                            case "main":
                                weather.Main = (string)detail.Value;
                                break;
                            case "description":
                                weather.Description = (string)detail.Value;
                                break;
                            case "icon":
                                weather.Icon = (string)detail.Value;
                                break;
                        }
                    }
                }
                break;
        }
    }
    public static void LoadAndParseJSONIntoObjects()
    {
        if (string.IsNullOrEmpty(JSONRawData))
        {
            using (WebClient webClient = new WebClient())
            {
                JSONRawData = webClient.DownloadString(JSONURL);
            }
        }
        JObject json = JObject.Parse(JSONRawData);
        List<JToken> data = json.Children().ToList();
        
        foreach (JProperty baseItem in data)
        {
            switch (baseItem.Name)
            {
                case "lat":
                    weather.Latitude = (double)baseItem.Value;
                    break;
                case "lon":
                    weather.Longitude = (double)baseItem.Value;
                    break;
                case "timezone":
                    weather.TimeZone = (string)baseItem.Value;
                    break;
                case "current":
                    List<JToken> currentItems = baseItem.Children().Children().ToList();
                    foreach (JProperty item in currentItems)
                    {
                        switch (item.Name)
                        {
                            case "sunrise":
                                weather.Sunrise = (long)item.Value;
                                break;
                            case "sunset":
                                weather.Sunset = (long)item.Value;
                                break;
                            case "temp":
                                weather.Temp = (double)item.Value;
                                break;
                            case "feels_like":
                                weather.Feels_Like = (double)item.Value;
                                break;
                            case "uvi":
                                weather.UVI = (double)item.Value;
                                break;
                            case "visibility":
                                weather.Visibility = (int)item.Value;
                                break;
                            default:
                                ParseSharedValues(weather, item);
                                break;
                        }
                    }
                    break;
                case "hourly":
                    List<JToken> hourlyItems = baseItem.Children().Children().ToList();
                    foreach (JToken item in hourlyItems)
                    {
                        WeatherHourly weatherHourlyItem = new WeatherHourly();
                        foreach (JProperty detail in item)
                        {
                            switch (detail.Name)
                            {
                                case "temp":
                                    weatherHourlyItem.Temp = (double)detail.Value;
                                    break;
                                case "feels_like":
                                    weatherHourlyItem.Feels_Like = (double)detail.Value;
                                    break;
                                default:
                                    ParseSharedValues(weatherHourlyItem, detail);
                                    break;
                            }
                        }
                        weatherHourlyItems.Add(weatherHourlyItem);
                    }
                    break;
                case "daily":
                    List<JToken> dailyItems = baseItem.Children().Children().ToList();
                    foreach (JToken item in dailyItems)
                    {
                        WeatherDaily weatherDailyItem = new WeatherDaily();
                        foreach (JProperty detail in item)
                        {
                            switch (detail.Name)
                            {
                                case "sunrise":
                                    weatherDailyItem.Sunrise = (long)detail.Value;
                                    break;
                                case "sunset":
                                    weatherDailyItem.Sunset = (long)detail.Value;
                                    break;
                                case "rain":
                                    weatherDailyItem.Rain = (double)detail.Value;
                                    break;
                                case "uvi":
                                    weatherDailyItem.UVI = (double)detail.Value;
                                    break;
                                case "temp":
                                    List<JToken> temps = detail.Children().Children().ToList();
                                    foreach (JProperty temp in temps)
                                    {
                                        switch (temp.Name)
                                        {
                                            case "day":
                                                weatherDailyItem.Temp_Day = (double)temp.Value;
                                                break;
                                            case "min":
                                                weatherDailyItem.Temp_Day_Min = (double)temp.Value;
                                                break;
                                            case "max":
                                                weatherDailyItem.Temp_Day_Max = (double)temp.Value;
                                                break;
                                            case "night":
                                                weatherDailyItem.Temp_Night = (double)temp.Value;
                                                break;
                                            case "eve":
                                                weatherDailyItem.Temp_Eve = (double)temp.Value;
                                                break;
                                            case "morn":
                                                weatherDailyItem.Temp_Morn = (double)temp.Value;
                                                break;
                                        }
                                    }
                                    break;
                                case "feels_like":
                                    List<JToken> feels = detail.Children().Children().ToList();
                                    foreach (JProperty feel in feels)
                                    {
                                        switch (feel.Name)
                                        {
                                            case "day":
                                                weatherDailyItem.Feels_Like_Day = (double)feel.Value;
                                                break;
                                            case "night":
                                                weatherDailyItem.Feels_Like_Night = (double)feel.Value;
                                                break;
                                            case "eve":
                                                weatherDailyItem.Feels_Like_Eve = (double)feel.Value;
                                                break;
                                            case "morn":
                                                weatherDailyItem.Feels_Like_Morn = (double)feel.Value;
                                                break;
                                        }
                                    }
                                    break;
                                default:
                                    ParseSharedValues(weatherDailyItem, detail);
                                    break;
                            }
                        }
                        weatherDailyItems.Add(weatherDailyItem);
                    }
                    break;
            }
        }
    }
}