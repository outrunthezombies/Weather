using System;
using System.ComponentModel;
using System.Windows.Forms;
using static SharedCode;
namespace Weather
{
    public partial class FormWeather : Form
    {
        public FormWeather()
        {
            InitializeComponent();
        }

        private void FormWeather_Load(object sender, EventArgs e)
        {
            LoadAndParseJSONIntoObjects();
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(weather))
            {
                textBox1.Text += ReturnStringValue(descriptor.Name, descriptor.GetValue(weather));
            }
            foreach (WeatherHourly item in weatherHourlyItems)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    textBox2.Text += ReturnStringValue(descriptor.Name, descriptor.GetValue(item));
                }
                textBox2.Text += "-----------------------------" + Environment.NewLine;
            }
            foreach (WeatherDaily item in weatherDailyItems)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    textBox3.Text += ReturnStringValue(descriptor.Name, descriptor.GetValue(item));
                }
                textBox3.Text += "-----------------------------" + Environment.NewLine;
            }
        }
        private string ReturnStringValue(string name, object value)
        {
            string temp = name + "=";
            switch (name)
            {
                case "Date":
                case "Sunrise":
                case "Sunset":
                    temp += DateAsString((long)value);
                    break;
                case "Temp":
                case "Feels_Like":
                case "Dew_Point":
                    temp += ((double)value-273d).ToString("0.#") + "°C";
                    break;
                default:
                    temp += value;
                    break;
            }
            temp += Environment.NewLine;
            return temp;
        }
    }
}