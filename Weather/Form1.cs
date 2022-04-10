using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            DateTimeTimer.Start();
            string time = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToLongTimeString();
            DateTimeLabel.Text = time.Substring(0, time.Length - 3);

            GetResponse();
        }

        /*
         * Custom moving, minimizing and closing the application
         */
        #region CustomWindowsForm

        /*
         * Custom moving the application
         */
        #region CustomTopPanel
        bool isClickMouse = false;
        Point currentPosition;

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isClickMouse)
            {
                Left += e.X - currentPosition.X;
                Top += e.Y - currentPosition.Y;
            }
        }
        #endregion

        /*
         * Icon the application
         */
        #region IconApplication
        private void IconApplication_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }

        private void IconApplication_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isClickMouse)
            {
                Left += e.X - currentPosition.X;
                Top += e.Y - currentPosition.Y;
            }
        }

        private void IconApplication_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;
        }
        #endregion

        /*
         * Close button the application
         */
        #region CloseButtonApplication
        private void CloseApplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        /*
         * Minimize button the application
         */
        #region MinimizeButtonApplication
        private void MinimizeApplication_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
            else
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        #endregion

        #endregion


        /*
         * Button for change day and weather information
         */
        #region DayWeatherButton
        private void TodayWeatherButton_Click(object sender, EventArgs e)
        {
            TextAboutDay.Text = "Today's Higtlights";
            TodayWeatherButton.ForeColor = Color.FromArgb(0, 0, 0);
            TomorrowWeatherButton.ForeColor = Color.FromArgb(160, 160, 160);
            TheDayAfterTomorrowButton.ForeColor = Color.FromArgb(160, 160, 160);

            changingWeatherData(0);
        }

        private void TomorrowWeatherButton_Click(object sender, EventArgs e)
        {
            TextAboutDay.Text = "Tomorrow's Higtlights";
            TodayWeatherButton.ForeColor = Color.FromArgb(160, 160, 160);
            TomorrowWeatherButton.ForeColor = Color.FromArgb(0, 0, 0);
            TheDayAfterTomorrowButton.ForeColor = Color.FromArgb(160, 160, 160);

            changingWeatherData(1);
        }

        private void TheDayAfterTomorrowButton_Click(object sender, EventArgs e)
        {
            TextAboutDay.Text = "The day after tomorrow's Higtlights";
            TodayWeatherButton.ForeColor = Color.FromArgb(160, 160, 160);
            TomorrowWeatherButton.ForeColor = Color.FromArgb(160, 160, 160);
            TheDayAfterTomorrowButton.ForeColor = Color.FromArgb(0, 0, 0);

            changingWeatherData(2);
        }
        #endregion

        /*
         * Timer for actual date and time
         */
        #region Date&Time
        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            string time = DateTime.Now.DayOfWeek.ToString() + ", " + DateTime.Now.ToLongTimeString();
            DateTimeLabel.Text = time.Substring(0, time.Length - 3);
            DateTimeTimer.Start();
        }
        #endregion

        /*
         * Get response
         */
        #region GetResponse

        public string response;

        private void GetResponse()
        {
            string APIkey = "046a4fd2f3c84149bac191443220804";
            string Town = "London";

            string url = $"http://api.weatherapi.com/v1/forecast.json?key={APIkey}&q={Town}&days=3";

            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }

            changingWeatherData(0);
        }

        public void changingWeatherData(int position)
        {
            Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(response);

            /*
             *  Min & Max emperature 
             */
            #region Min&MaxTemperature
            MinTemperature.Text = myDeserializedClass.forecast.forecastday[position].day.mintemp_c.ToString() + "°";
            MaxTemperature.Text = myDeserializedClass.forecast.forecastday[position].day.maxtemp_c.ToString() + "°";
            #endregion

            /*
             *  Sunrise & Sunset time
             */
            #region Sunrise&SundetTime
            Sunrise.Text = myDeserializedClass.forecast.forecastday[position].astro.sunrise;
            Sunset.Text = myDeserializedClass.forecast.forecastday[position].astro.sunset;
            #endregion

            /*
             * Wind speed and status
             */
            #region WindStatus
            WindKilometrsPerHour.Text = myDeserializedClass.forecast.forecastday[position].day.maxwind_kph.ToString() + " km/h";

            string wind = "";
            double windRate = myDeserializedClass.forecast.forecastday[position].day.maxwind_kph;
            if (windRate >= 0 && windRate <= 5)
            {
                wind = "Weak wind";
            }
            else if (windRate > 5 && windRate <= 14)
            {
                wind = "Moderate wind";
            }
            else if (windRate > 14 && windRate <= 24)
            {
                wind = "Strong wind";
            }
            else if (windRate > 24 && windRate <= 32)
            {
                wind = "Very strong wind";
            }
            else if (windRate > 32)
            {
                wind = "Hurricane wind";
            }

            WindStatus.Text = wind;
            #endregion

            /*
             * Range and visibility status
             */
            #region VisibilityStatus
            VisibilityInKilometers.Text = myDeserializedClass.forecast.forecastday[position].day.avgvis_km.ToString() + " km";

            string visibility = "";
            double visibilityRate = myDeserializedClass.forecast.forecastday[position].day.avgvis_km;
            if (visibilityRate >= 0 && visibilityRate <= 1)
            {
                visibility = "Terrible visibility";
            }
            else if (visibilityRate > 1 && visibilityRate <= 4)
            {
                visibility = "Bad visibility";
            }
            else if (visibilityRate > 4 && visibilityRate <= 10)
            {
                visibility = "Normal visibility";
            }
            else if (visibilityRate > 10 && visibilityRate <= 20)
            {
                visibility = "Good visibility";
            }
            else if (visibilityRate > 20)
            {
                visibility = "Excellent visibility";
            }

            VisibilityStatus.Text = visibility;
            #endregion

            /*
             * Humidity level and status
             */
            #region HumidityStatus
            HumidityInPercent.Text = myDeserializedClass.forecast.forecastday[position].day.avghumidity.ToString() + "%";

            string humidity = "";
            double humidityRate = myDeserializedClass.forecast.forecastday[position].day.avghumidity;
            if (humidityRate >= 0 && humidityRate <= 20)
            {
                humidity = "Extremely low humidity";
            }
            else if (humidityRate > 20 && humidityRate <= 40)
            {
                humidity = "Low humidity";
            }
            else if (humidityRate > 40 && humidityRate <= 55)
            {
                humidity = "Optimal humidity";
            }
            else if (humidityRate > 55 && humidityRate <= 65)
            {
                humidity = "Heightened humidity";
            }
            else if (humidityRate > 65 && humidityRate <= 80)
            {
                humidity = "High humidity";
            }
            else if (humidityRate > 80)
            {
                humidity = "Extremely high humidity";
            }

            HumidityStatus.Text = humidity;
            #endregion
        }

        /*
         * Get json format in normal form
         */
        #region ConvertedJson
        public class Location
        {
            public string name { get; set; }
            public string region { get; set; }
            public string country { get; set; }
            public double lat { get; set; }
            public double lon { get; set; }
            public string tz_id { get; set; }
            public int localtime_epoch { get; set; }
            public string localtime { get; set; }
        }

        public class Condition
        {
            public string text { get; set; }
            public string icon { get; set; }
            public int code { get; set; }
        }

        public class Current
        {
            public int last_updated_epoch { get; set; }
            public string last_updated { get; set; }
            public double temp_c { get; set; }
            public double temp_f { get; set; }
            public int is_day { get; set; }
            public Condition condition { get; set; }
            public double wind_mph { get; set; }
            public double wind_kph { get; set; }
            public int wind_degree { get; set; }
            public string wind_dir { get; set; }
            public double pressure_mb { get; set; }
            public double pressure_in { get; set; }
            public double precip_mm { get; set; }
            public double precip_in { get; set; }
            public int humidity { get; set; }
            public int cloud { get; set; }
            public double feelslike_c { get; set; }
            public double feelslike_f { get; set; }
            public double vis_km { get; set; }
            public double vis_miles { get; set; }
            public double uv { get; set; }
            public double gust_mph { get; set; }
            public double gust_kph { get; set; }
        }

        public class Day
        {
            public double maxtemp_c { get; set; }
            public double maxtemp_f { get; set; }
            public double mintemp_c { get; set; }
            public double mintemp_f { get; set; }
            public double avgtemp_c { get; set; }
            public double avgtemp_f { get; set; }
            public double maxwind_mph { get; set; }
            public double maxwind_kph { get; set; }
            public double totalprecip_mm { get; set; }
            public double totalprecip_in { get; set; }
            public double avgvis_km { get; set; }
            public double avgvis_miles { get; set; }
            public double avghumidity { get; set; }
            public int daily_will_it_rain { get; set; }
            public int daily_chance_of_rain { get; set; }
            public int daily_will_it_snow { get; set; }
            public int daily_chance_of_snow { get; set; }
            public Condition condition { get; set; }
            public double uv { get; set; }
        }

        public class Astro
        {
            public string sunrise { get; set; }
            public string sunset { get; set; }
            public string moonrise { get; set; }
            public string moonset { get; set; }
            public string moon_phase { get; set; }
            public string moon_illumination { get; set; }
        }

        public class Hour
        {
            public int time_epoch { get; set; }
            public string time { get; set; }
            public double temp_c { get; set; }
            public double temp_f { get; set; }
            public int is_day { get; set; }
            public Condition condition { get; set; }
            public double wind_mph { get; set; }
            public double wind_kph { get; set; }
            public int wind_degree { get; set; }
            public string wind_dir { get; set; }
            public double pressure_mb { get; set; }
            public double pressure_in { get; set; }
            public double precip_mm { get; set; }
            public double precip_in { get; set; }
            public int humidity { get; set; }
            public int cloud { get; set; }
            public double feelslike_c { get; set; }
            public double feelslike_f { get; set; }
            public double windchill_c { get; set; }
            public double windchill_f { get; set; }
            public double heatindex_c { get; set; }
            public double heatindex_f { get; set; }
            public double dewpoint_c { get; set; }
            public double dewpoint_f { get; set; }
            public int will_it_rain { get; set; }
            public int chance_of_rain { get; set; }
            public int will_it_snow { get; set; }
            public int chance_of_snow { get; set; }
            public double vis_km { get; set; }
            public double vis_miles { get; set; }
            public double gust_mph { get; set; }
            public double gust_kph { get; set; }
            public double uv { get; set; }
        }

        public class Forecastday
        {
            public string date { get; set; }
            public int date_epoch { get; set; }
            public Day day { get; set; }
            public Astro astro { get; set; }
            public List<Hour> hour { get; set; }
        }

        public class Forecast
        {
            public List<Forecastday> forecastday { get; set; }
        }

        public class Root
        {
            public Location location { get; set; }
            public Current current { get; set; }
            public Forecast forecast { get; set; }
        }
        #endregion
        #endregion
    }
}