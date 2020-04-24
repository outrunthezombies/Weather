using System;
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
        }
    }
}
