using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }
        [Required, MaxLength(25)]
        public string CompanyName { get; set; }

        public ICollection<Client> Clients { get; set; }

        public Company()
        {
        }

        public Company(int companyID, string companyName)
        {
            CompanyID = companyID;
            CompanyName = companyName;
        }
    }
}
