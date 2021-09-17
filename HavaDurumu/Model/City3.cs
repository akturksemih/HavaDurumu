using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumu.Model
{
    public class City3
    {
        public string Sehir3 { get; set; }
        public string Hava3 { get; set; }
        public string Derece3 { get; set; }
        public string WeatherImage3 { get; set; }

        public City3()
        {
            this.Sehir3 = " İZMİR ";
            this.Hava3 = " Parçalı Bulutlu ";
            this.Derece3 = " 34 °C ";
            this.WeatherImage3 = " Assets/parçalıbulutlu.png";
        }
    }
    public class City3ViewModel
    {
        private City3 defaultCity3 = new City3();
        public City3 DefaultCity3 { get { return this.defaultCity3; } }
    }
}
