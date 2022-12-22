using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Required, MaxLength(25)]
        public string BuildingNameNumber { get; set; }
        [MaxLength(25)]
        public City CityName {get; set;}
        [Required, MaxLength(8)]
        public string Postcode { get; set; }


        public Address()
        {
        }

        public Address(int addressID, string buildingNameNumber, City cityName, string postcode)
        {
            AddressID = addressID;
            BuildingNameNumber = buildingNameNumber;
            CityName = cityName;
            Postcode = postcode;
        }
    }
}
