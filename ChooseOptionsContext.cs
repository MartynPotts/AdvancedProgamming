using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
