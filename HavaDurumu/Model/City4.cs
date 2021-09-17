using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumu.Model
{
    public class City4
    {
        public string Sehir4 { get; set; }
        public string Hava4 { get; set; }
        public string Derece4 { get; set; }
        public string WeatherImage4 { get; set; }

        public City4()
        {
            this.Sehir4 = " ADANA ";
            this.Hava4 = " Güneşli ";
            this.Derece4 = " 39 °C ";
            this.WeatherImage4 = " Assets/güneşli.png";
        }
    }
    public class City4ViewModel
    {
        private City4 defaultCity4 = new City4();
        public City4 DefaultCity4 { get { return this.defaultCity4; } }
    }
}
