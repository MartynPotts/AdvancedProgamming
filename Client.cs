﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    public class Client
    {
        [Key]
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

        [Required]
        public Department Department { get; set; }

        

        [Required]
        public Address Address { get; set; }

        public Client()
        {
        }

        
    }
}