namespace weatherapp
{
    public class Vreme
    {
        public class Coord
        {
            public double lon;
            public double lat;
        }

        public class Weather
        {
            public string main;
            public string description;
            public string Icon;
        }

        public class Main
        {
            public double temp;
            public double feels_like;
            public double temp_min;
            public double temp_max;
            public double humidity;
        }

        public class Sys
        {
            public long sunrise;
            public long sunset;
            public int cod;
            public string country;
        }

        public class Wind
        {
            public double speed;
        }
        public class Root
        {
            public Coord coord { get; set; }
            public List <Weather> weather { get; set; }
            public Main main { get; set; }
            public Sys sys { get; set; }
            public Wind wind { get; set; }
            public int timezone { get; set; }
            public string name { get; set; }

        }

    }
}
