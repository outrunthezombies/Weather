using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using System.Net;

public static class SharedCode
{
    private static readonly string APPID = "e2a6fd9fa5221cdb191800358b8c1376";
    private static readonly string APIVersion = "/data/2.5";
    private static readonly string APIURL = "http://api.openweathermap.org";
    private static readonly string APIApp = "/onecall";
    private static double latitude = 43.658220;
    private static double longitude = -79.478610;
    private static readonly string JSONURL = APIURL + APIVersion + APIApp + "?appid=" + APPID + "&lat=" + latitude + "&lon=" + longitude;
    private static string JSONRawData;
    public static List<JToken> GetJProperties(List<JToken> items)
    {
        return items;
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
                    break;
                case "lon":
                    break;
                case "timezone":
                    break;
                case "current":
                    List<JToken> items = baseItem.Children().Children().ToList();
                    foreach (JProperty item in items)
                    {
                        switch (item.Name)
                        {
                            case "dt":
                                break;
                            case "sunrise":
                                break;
                            case "sunset":
                                break;
                            case "temp":
                                break;
                            case "feels_like":
                                break;
                            case "pressure":
                                break;
                            case "humidity":
                                break;
                            case "dew_point":
                                break;
                            case "uvi":
                                break;
                            case "clouds":
                                break;
                            case "visibility":
                                break;
                            case "wind_speed":
                                break;
                            case "wind_deg":
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
                                                break;
                                            case "main":
                                                break;
                                            case "description":
                                                break;
                                            case "icon":
                                                break;
                                        }
                                    }
                                }
                                break;
                        }
                    }
                    break;
                case "hourly":
                    List<JToken> hourlyDetails = baseItem.Children().Children().ToList();
                    foreach (JToken hourlyDetail in hourlyDetails)
                    {
                        foreach (JProperty detail in hourlyDetail)
                        {
                            switch (detail.Name)
                            {
                                case "f":
                                    break;
                            }
                        }
                    }
                    break;
                case "daily":
                    break;
            }
        }
    }
}