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
    [Table("Client")]
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientID { get; set; }
        [Required, MaxLength(25)]
        public string ContactName { get; set; }
        [Required, MaxLength(50)]
        public string ContactEmail { get; set; }
        [Required, MaxLength(13)]
        public string ContactPhoneNumber { get; set; }

        [Display(Name = "Company")]
        public virtual int CompanyID { get; set; }
        [ForeignKey("CompanyID")]
        public virtual Company Company { get; set; }

        [Display(Name ="Department")]
        public virtual int DepartmentID { get; set; }
        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [Display(Name ="Address")]
        public virtual int AddressID { get; set; }
        [ForeignKey("AddressID")]
        public virtual Address Address { get; set; }

        public Client()
        {

        }
        public Client(int clientID, string contactName, string contactEmail, string contactPhoneNumber, Company company, Department department, Address address)
        {
            ClientID = clientID;
            ContactName = contactName;
            ContactEmail = contactEmail;
            ContactPhoneNumber = contactPhoneNumber;
            Company = company;
            Department = department;
            Address = address;
        }
    }
}
