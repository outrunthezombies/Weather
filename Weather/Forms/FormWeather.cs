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
            DebugOutput();
        }
        private void DebugOutput()
        {
            this.Cursor = Cursors.WaitCursor;
            string text1 = "";
            string text2 = "";
            string text3 = "";
            foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(weather))
            {
                text1 += ReturnStringValue(descriptor.Name, descriptor.GetValue(weather));
            }
            foreach (WeatherHourly item in weatherHourlyItems)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    text2 += ReturnStringValue(descriptor.Name, descriptor.GetValue(item));
                }
                text2 += "-----------------------------" + Environment.NewLine;
            }
             foreach (WeatherDaily item in weatherDailyItems)
            {
                foreach (PropertyDescriptor descriptor in TypeDescriptor.GetProperties(item))
                {
                    text3 += ReturnStringValue(descriptor.Name, descriptor.GetValue(item));
                }
                text3 += "-----------------------------" + Environment.NewLine;
            }
            textBox1.Text = text1;
            textBox2.Text = text2;
            textBox3.Text = text3;
            this.Cursor = Cursors.Default;
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
                    if (RdoCelcius.Checked)
                        temp += ReturnTemparatureFormatted((double)value, TempType.Celcius);
                    else if (RdoFahrenheit.Checked)
                        temp += ReturnTemparatureFormatted((double)value, TempType.Fahrenheit);
                    else
                        temp += ReturnTemparatureFormatted((double)value, TempType.Kelvin);
                    break;
                case "Wind_Speed":
                    if (RdoKph.Checked)
                        temp += ReturnSpeedFormatted((double)value, SpeedType.Kph) + " Kph";
                    else
                        temp += ReturnSpeedFormatted((double)value, SpeedType.Mph) + " Mph";
                    break;
                default:
                    temp += value;
                    break;
            }
            temp += Environment.NewLine;
            return temp;
        }

        private void RdoCelcius_Click(object sender, EventArgs e)
        {
            DebugOutput();
        }
        private void RdoFahrenheit_Click(object sender, EventArgs e)
        {
            DebugOutput();
        }
        private void RdoKelvin_Click(object sender, EventArgs e)
        {
            DebugOutput();
        }
        private void BtnLoad_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            LoadAndParseJSONIntoObjects();
            DebugOutput();
            this.Cursor = Cursors.Default;
        }

        private void RdoMph_Click(object sender, EventArgs e)
        {
            DebugOutput();
        }

        private void RdoKph_Click(object sender, EventArgs e)
        {
            DebugOutput();
        }
    }
}