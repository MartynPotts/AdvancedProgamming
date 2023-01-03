using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwayDayPlanner
{
    [Table("City")]
    public class City
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityID { get; set; }
        [Required, MaxLength(25)]
        public string CityName { get; set; }

        public City(int cityID, string cityName)
        {
            CityID = cityID;
            CityName = cityName;
        }

        public City()
        {
        }
    }
}

