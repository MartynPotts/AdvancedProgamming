using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Author: Durgambica Padarthi  StudentID: W21056804

namespace AwayDayPlanner
{
    public class ChooseOptionsContext : DbContext
    {
        public  DbSet<AwaydayRequestEstimation> RequestEstimationsdb
        {
            get;
            set;
        }
        
    }
}
