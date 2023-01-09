using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Martyn Potts StudentID: W19005228

namespace AwayDayPlanner
{
    [Table("Address")]
    public partial class Address
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AddressID { get; set; }
        [Required, MaxLength(25)]
        public string BuildingNameNumber { get; set; }
        [Required, MaxLength(8)]
        public string Postcode { get; set; }

        [Display(Name ="City")]
        public virtual int CityID { get; set; }
        [ForeignKey("CityID")]
        public virtual City CityName { get; set; }

        public Address()
        {
        }

        public Address(int addressID, string buildingNameNumber, string postcode, City cityName)
        {
            AddressID = addressID;
            BuildingNameNumber = buildingNameNumber;
            Postcode = postcode;
            CityName = cityName;
        }
    }
}
