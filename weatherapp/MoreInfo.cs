using System.Net;

namespace weatherapp
{
    public partial class MoreInfo : Form
    {
        private string SearchText = "";
        private Vreme.Root WeatherInfo;
        public MoreInfo(Vreme.Root weatherInfo)
        {
            WeatherInfo = weatherInfo;
            InitializeComponent();
            labelMestoDisplay.Text = WeatherInfo.name;
            labelLowestTemp.Text = Math.Round((WeatherInfo.main.temp_min - 273), 0).ToString() + "°C";
            labelHighestTemp.Text = Math.Round((WeatherInfo.main.temp_max - 273), 0).ToString() + "°C";
            labelFeelsLike.Text = Math.Round((WeatherInfo.main.temp_max - 273), 0).ToString() + "° C";
            labelLon.Text = WeatherInfo.coord.lon.ToString();
            labelLat.Text = WeatherInfo.coord.lat.ToString();
            labelCountry.Text = WeatherInfo.sys.country;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
