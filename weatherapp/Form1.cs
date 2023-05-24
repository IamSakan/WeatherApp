using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static weatherapp.Vreme;

namespace weatherapp
{
    public partial class Form1 : Form
    {
        private string APIKey = "2a4106053bcff7e70287a9b3f3088d4c";
        private string searchHistoryFile = "search_history.txt";

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("sunrise.png");
            pictureBox3.Image = Image.FromFile("sunset.png");
            pictureBoxHumidity.Image = Image.FromFile("humidity.png");
            pictureBoxWind.Image = Image.FromFile("wind.png");

            comboBoxMesto.KeyDown += ComboBoxMesto_KeyDown;
            LoadSearchHistory();
            buttonOblacila.Enabled = false; 

        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void ComboBoxMesto_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the Enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                getWeather();
                e.SuppressKeyPress = true;
            }
        }

        string clothingRecommendation = "";
        int timezone;
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                try
                {
                    string searchText = comboBoxMesto.Text.Trim();
                    string url = $"https://api.openweathermap.org/data/2.5/weather?q={searchText}&appid={APIKey}";
                    var json = web.DownloadString(url);
                    Vreme.root Info = JsonConvert.DeserializeObject<Vreme.root>(json);
                    pictureBoxWeather.ImageLocation = Info.weather[0].Icon + ".png";
                    timezone = Info.timezone;
                    labelCondition.Text = Info.weather[0].main;
                    labelDetails.Text = Info.weather[0].description;
                    labelSunrise.Text = pretvarjanjeCasa(Info.sys.sunrise, timezone).ToShortTimeString();
                    labelSunset.Text = pretvarjanjeCasa(Info.sys.sunset, timezone).ToShortTimeString();
                    SaveSearchHistory(searchText); // shrani zgodovino iskanja

                    labelTemp.Text = Math.Round((Info.main.temp - 273), 0).ToString() + "°C";
                    labelMinTemp.Text = Math.Round((Info.main.temp_min - 273), 0).ToString() + "°C";
                    labelMaxTemp.Text = Math.Round((Info.main.temp_max - 273), 0).ToString() + "°C";
                    labelFeelsLike.Text = Math.Round((Info.main.feels_like - 273), 0).ToString() + "°C";
                    labelWind.Text = Math.Round((Info.wind.speed * 3.6), 1).ToString() + "km/h";
                    labelHumidity.Text = Info.main.humidity.ToString() + "%";
                    
                    labelMestoDisp.Text = comboBoxMesto.Text;
                    if (Info.weather[0].main.ToLower() == "rain")
                    {
                        Oblacila currentWeather = new Oblacila(Info.main.temp - 273, true, false);
                        clothingRecommendation = currentWeather.GetClothingRecommendation();
                    }

                    else if(Info.weather[0].main.ToLower() == "clouds" || Info.weather[0].main.ToLower() == "sunny" || Info.weather[0].main.ToLower() == "clear")
                    {
                        Oblacila currentWeather = new Oblacila(Info.main.temp - 273, false, true);
                        clothingRecommendation = currentWeather.GetClothingRecommendation();
                    }
                    buttonOblacila.Enabled = true;

                }
                catch (WebException ex)
                {
                    MessageBox.Show("An error occurred while retrieving the weather information. Please check the entered location and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        DateTime pretvarjanjeCasa(long ms, int timezone)
        {
            int hec = timezone / 3600; //tle bo zdaj 2, js sm meu prej 1
            DateTime day; 
            if (timezone > 0) 
            {
                day = new DateTime(1970, 1, 1,Math.Abs(hec-1), 0, 0, 0, DateTimeKind.Utc).ToLocalTime(); //leto mesec dan ura minuta sekunda milisekunda
                day = day.AddSeconds(ms).ToLocalTime();
            }

            else //to je zdj za negativne
            {
                day = new DateTime(1970, 1, 1,23 - Math.Abs(hec), 0, 0, 0, DateTimeKind.Utc).ToLocalTime(); 
                day = day.AddSeconds(ms).ToLocalTime();
            }
            return day;
        }

        private void SaveSearchHistory(string searchText)
        {
            try
            {
                List<string> searchHistory = new List<string>();

                if (File.Exists(searchHistoryFile))
                {
                    searchHistory = File.ReadAllLines(searchHistoryFile).ToList();
                    searchHistory.Remove(searchText);
                }

                searchHistory.Insert(0, searchText);

                if (searchHistory.Count > 5)
                {
                    searchHistory = searchHistory.Take(5).ToList();
                }

                File.WriteAllLines(searchHistoryFile, searchHistory);
            }
            catch (IOException ex)
            {
                // Handle the exception, e.g., display an error message
                MessageBox.Show("An error occurred while saving the search history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void LoadSearchHistory()
        {
            try
            {
                if (File.Exists(searchHistoryFile))
                {
                    List<string> searchHistory = File.ReadAllLines(searchHistoryFile).ToList();
                    int startIndex = Math.Max(0, searchHistory.Count - 5); // Get the starting index based on the number of items to display
                    List<string> latestSearches = searchHistory.GetRange(startIndex, Math.Min(5, searchHistory.Count)); // Get the latest 5 items or less
                    comboBoxMesto.Items.AddRange(latestSearches.ToArray());
                }
            }
            catch (IOException ex)
            {
                // Handle the exception, e.g., display an error message
                MessageBox.Show("An error occurred while loading the search history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void buttonOblacila_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clothingRecommendation, "Our recommendation for your clothes based on current weather:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
