using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redis.Common
{
    public class ParticipantAnnualReportKeyDataPoints
    {
        public int PersonID { get; set; }
        public bool IsTerminated { get; set; }
        public bool IsExpat { get; set; }
        public bool IsDeceased { get; set; }
        public bool IsWait { get; set; }
    }
}
