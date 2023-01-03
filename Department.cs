using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [Required, MaxLength(50)]
        public string DepartmentName { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<Company> Companies { get; set; }

        public Department()
        {
            Addresses = new List<Address>();
            Companies = new List<Company>();
        }

        
    }

}
