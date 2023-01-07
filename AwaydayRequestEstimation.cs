using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwayDayPlanner
{
    
    public class AwaydayRequestEstimation
    {
        [Key]
     public int clientID
        {
            get;
            set;
        }
     
        public string plannedFromDate
        {
            get;
            set;
        }

        
       
        public string bookingServiceType
        {
            get;
            set;
        }

        public int plannedAwayDays
        {
            get;
            set;
        }
        public int eventattendeescount
        {
            get;
            set;

        }

        
        public string AdditionalFacilityDescription
        {
            get;
            set;
        }

    }
}
