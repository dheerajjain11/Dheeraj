using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Redis.Business;
using Redis.DataAccess;
using Redis.Common;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();
            ParticipantAnnualReportKeyDataPoints[] participantArray = p.RunBusinessFlow();
            DataProcessor processor = new DataProcessor();

            //processor.TestRedisConnection();
            processor.InsertAll(participantArray);
        }
    }
}
