using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumu.Model
{
    public class City2
    {
        public string Sehir2 { get; set; }
        public string Hava2 { get; set; }
        public string Derece2 { get; set; }
        public string WeatherImage2 { get; set; }

        public City2()
        {
            this.Sehir2 = " ANKARA ";
            this.Hava2 = " Yağmurlu ";
            this.Derece2 = " 24 °C ";
            this.WeatherImage2 = " Assets/yağmurlu.png";
        }
    }
    public class City2ViewModel
    {
        private City2 defaultCity2 = new City2();
        public City2 DefaultCity2 { get { return this.defaultCity2; } }
    }
}
