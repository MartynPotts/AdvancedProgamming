using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    [Table("Address")]
    public partial class Address
    {
        [Key]
        public int AddressID { get; set; }
        [Required, MaxLength(25)]
        public string BuildingNameNumber { get; set; }
        [Required, MaxLength(8)]
        public string Postcode { get; set; }

        [Display(Name ="City")]
        public virtual int CityID { get; set; }
        [ForeignKey("CityID")]
        public virtual City CityName { get; set; }

       public ICollection<Client> Clients { get; set; }
    }
}
