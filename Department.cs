using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    [Table("Department")]
    public class Department
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
