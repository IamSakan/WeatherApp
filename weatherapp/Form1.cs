using Newtonsoft.Json;
using System.Net;

namespace weatherapp
{
    public partial class Form1 : Form
    {
        private MoreInfo moreInfo;
        private string APIKey = "2a4106053bcff7e70287a9b3f3088d4c";
        private string searchHistoryFile = "search_history.txt";
        private Vreme.Root WeatherInfo;
        private bool isFullscreen = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox2.Image = Image.FromFile("sunrise.png");
            pictureBox3.Image = Image.FromFile("sunset.png");
            pictureBoxHumidity.Image = Image.FromFile("humidity.png");
            pictureBoxWind.Image = Image.FromFile("wind.png");

            pictureBox2.BackColor = Color.FromArgb(125, Color.White);
            pictureBox3.BackColor = Color.FromArgb(125, Color.White);
            pictureBoxHumidity.BackColor = Color.FromArgb(125, Color.White);
            pictureBoxWind.BackColor = Color.FromArgb(125, Color.White);

            comboBoxMesto.KeyDown += ComboBoxMesto_KeyDown;
            LoadSearchHistory();
            buttonOblacila.Enabled = false;
            panel1.BackColor = Color.FromArgb(125, Color.Black);
            buttonSearch.BackColor = Color.FromArgb(125, Color.Black);
            pictureBoxWeather.BackColor = Color.FromArgb(125, Color.Black);
            buttonMoreInfo.Enabled = false;
            comboBoxMesto.Select(); // da lahko takoj pišemo, brez da bi morali pritisniti na comboBox

        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void ComboBoxMesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                isFullscreen = true;
            }
            // preveri èe pritisnemo enter in poklièe funkcijo 
            if (e.KeyCode == Keys.Enter)
            {
                getWeather();
                e.SuppressKeyPress = true;
            }   
            // f11 za fullscreen
            else if (e.KeyCode == Keys.F11)
            {
                if (isFullscreen)
                {
                    // exit fullscreen mode
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    this.WindowState = FormWindowState.Normal;
                    isFullscreen = false;
                }
                else
                {
                    // enter fullscreen mode
                    //this.FormBorderStyle = FormBorderStyle.None; // ni mi všeè
                    this.WindowState = FormWindowState.Maximized;
                    isFullscreen = true;
                    ShowFullscreenMessage();
                }
            }
        }
        private void ShowFullscreenMessage()
        {
            MessageBox.Show("Press F11 again to exit fullscreen mode.", "Fullscreen Mode", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    Vreme.Root Info = JsonConvert.DeserializeObject<Vreme.Root>(json);
                    pictureBoxWeather.ImageLocation = Info.weather[0].Icon + ".png"; // ni delalo èe load-am sliko prek url-ja, pa sem naložil vse slike (ni jih velik)
                    timezone = Info.timezone;
                    labelCondition.Text = Info.weather[0].main;
                    labelDetails.Text = Info.weather[0].description;
                    labelSunrise.Text = pretvarjanjeCasa(Info.sys.sunrise, timezone).ToShortTimeString(); // da izpiše samo èas brez datuma, sekund..
                    labelSunset.Text = pretvarjanjeCasa(Info.sys.sunset, timezone).ToShortTimeString();
                    SaveSearchHistory(Info.name); // shrani zgodovino iskanja

                    labelTemp.Text = Math.Round((Info.main.temp - 273), 0).ToString() + "°C"; // iz kelvinov v stopinje C pretvorimo da odštejemo 273
                    labelWind.Text = Math.Round((Info.wind.speed * 3.6), 1).ToString() + "km/h"; // pretvorimo iz m/s v km/h
                    labelHumidity.Text = Info.main.humidity.ToString() + "%"; 
                    
                    labelMestoDisp.Text = Info.name;
                    if (Info.weather[0].main.ToLower() == "rain") // ce je dez, objektu damo vrednost true za dez in false za sonce
                    {
                        Oblacila currentWeather = new Oblacila(Info.main.temp - 273, true, false);
                        clothingRecommendation = currentWeather.GetClothingRecommendation(); // klic funkcije
                    }

                    else if(Info.weather[0].main.ToLower() == "clouds" || Info.weather[0].main.ToLower() == "sunny" || Info.weather[0].main.ToLower() == "clear") 
                    {
                        Oblacila currentWeather = new Oblacila(Info.main.temp - 273, false, true);
                        clothingRecommendation = currentWeather.GetClothingRecommendation();
                    }
                    buttonOblacila.Enabled = true; 
                    buttonMoreInfo.Enabled = true;
                    WeatherInfo = Info; // v spremenljivko, ki jo pošljemo v drug forms, zapišemo vrednosti ki jih prebere objekt Info
                

                }
                catch (WebException ex)
                {
                    MessageBox.Show("An error occurred while retrieving the weather information. Please check the entered location and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        DateTime pretvarjanjeCasa(long ms, int timezone) 
        {
            int idk = timezone / 3600; // ker sem ugotovil da je 3600 edina ki je pravilno delovala na zaèetku, sem jo vzel kot osnovno
            DateTime day; 
            if (timezone > 0) 
            {
                day = new DateTime(1970, 1, 1,Math.Abs(idk-1), 0, 0, 0, DateTimeKind.Utc).ToLocalTime(); // leto mesec dan ura minuta sekunda milisekunda
                day = day.AddSeconds(ms).ToLocalTime();
            }

            else // za negativne vrednosti spremenljivke timezone
            {
                day = new DateTime(1970, 1, 1,23 - Math.Abs(idk), 0, 0, 0, DateTimeKind.Utc).ToLocalTime(); 
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
                    searchHistory = File.ReadAllLines(searchHistoryFile).ToList(); // èe datoteka obstaja, prebere vse vrstice iz datoteke in jih pretvori v list
                    searchHistory.Remove(searchText); // odstrani niz èe je že prisoten v seznamu / da ne bi prišlo do ponavljanja
                }

                searchHistory.Insert(0, searchText); // zapis na prvo mesto

                if (searchHistory.Count > 5)  
                {
                    searchHistory = searchHistory.Take(5).ToList(); // èe je veè ko 5 zapisov izberemo prvih 5 in jih zapišemo v list
                }

                File.WriteAllLines(searchHistoryFile, searchHistory); //zapis novih 5
            }
            catch (IOException ex)
            {
                // v primeru napake izpiše error, ni delalo brez tega.
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
                    int startIndex = Math.Max(0, searchHistory.Count - 5); // glede na število elementov, vrne najveèje število, kar je indeks zadnjega elementa
                    List<string> latestSearches = searchHistory.GetRange(startIndex, Math.Min(5, searchHistory.Count)); // GetRange() - za izbiro podseznama na podlagi zaèetnega indeksa in števila elementov.
                    comboBoxMesto.Items.AddRange(latestSearches.ToArray()); // AddRange() - za dodajanje veè elementov hkrati
                }
            }
            catch (IOException ex)
            {
                // Pri napaènem vnosu, vrne error
                MessageBox.Show("An error occurred while loading the search history.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void buttonOblacila_Click(object sender, EventArgs e)
        {
            MessageBox.Show(clothingRecommendation, "Our recommendation for your clothes based on current weather:", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonMoreInfo_Click(object sender, EventArgs e)
        {
            if (moreInfo == null || moreInfo.IsDisposed)
            {
                moreInfo = new MoreInfo(WeatherInfo); // da lahko izpišem potrebne stvari
            }

            moreInfo.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
