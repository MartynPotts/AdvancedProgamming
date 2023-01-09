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
    [Table("Company")]
    public class Company
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyID { get; set; }
        [Required, MaxLength(25)]
        public string CompanyName { get; set; }

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
