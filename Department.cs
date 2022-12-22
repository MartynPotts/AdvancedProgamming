using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        [Required, MaxLength(50)]
        public string DepartmentName { get; set; }

        public Department()
        {
        }

        public Department(int departmentID, string departmentName)
        {
            DepartmentID = departmentID;
            DepartmentName = departmentName;
        }
    }

}
