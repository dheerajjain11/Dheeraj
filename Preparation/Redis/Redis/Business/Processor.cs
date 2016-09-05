using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Redis.Common;

namespace Redis.Business
{
    class Processor
    {
        public ParticipantAnnualReportKeyDataPoints[] RunBusinessFlow()
        {
            ParticipantAnnualReportKeyDataPoints[] participantArray = new ParticipantAnnualReportKeyDataPoints[100000];

            for (int i = 0; i < 100000; i++)
            {
                participantArray[i] = new ParticipantAnnualReportKeyDataPoints();
                participantArray[i].IsDeceased = i % 100 == 0 ? true : false;
                participantArray[i].IsExpat = i % 40 == 0 ? true : false;
                participantArray[i].IsTerminated = i % 15 == 0 ? true : false;
                participantArray[i].IsWait = i % 20 == 0 ? true : false;
                participantArray[i].PersonID = i + 1;
            }
            return participantArray;
        }
    }
}
