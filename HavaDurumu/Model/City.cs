using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumu.Model
{
    public class City
    {
        public string Sehir { get; set; }    
        public string Hava { get; set; }    
        public string Derece { get; set; }    
        public string WeatherImage { get; set; }    
        public City()
        {
            this.Sehir = " İSTANBUL ";   
            this.Hava = " Rüzgarlı ";            
            this.Derece = " 28 °C ";                        
            this.WeatherImage = " Assets/rüzgarlı.png";                       
        }
    }
    public class CityViewModel
    {
        private City defaultCity = new City();
        public City DefaultCity { get { return this.defaultCity; } }
    }
}