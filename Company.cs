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

        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }

        public Company()
        {
            Departments = new List<Department>();
            Addresses = new List<Address>();
        }
       
    }
}
