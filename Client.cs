using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    class Client
    {
        [Key]
        public int ClientID { get; set; }
        [Required, MaxLength(25)]
        public string ContactName { get; set; }
        [Required]
        public Company Company { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required, MaxLength(50)]
        public string ContactEmail { get; set; }
        [Required,MaxLength(13)]
        public string ContactPhoneNumber { get; set; }
        [Required]
        public Address Address { get; set; }

        public Client()
        {
        }

        public Client(int clientID, string contactName, Company company, Department department, string contactEmail, string contactPhoneNumber, Address address)
        {
            ClientID = clientID;
            ContactName = contactName;
            Company = company;
            Department = department;
            ContactEmail = contactEmail;
            ContactPhoneNumber = contactPhoneNumber;
            Address = address;
        }
    }
}
