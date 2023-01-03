using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AwayDayPlanner
{
    public class City
    {
        [Key]
        public int CityID { get; set; }
        [Required, MaxLength(25)]
        public string CityName { get; set; }

        public City()
        {
        }

        public City(int cityID, string cityName)
        {
            CityID = cityID;
            CityName = cityName;
        }
    }
}

