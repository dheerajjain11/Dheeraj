using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Redis.Business;
using Redis.DataAccess;

namespace Redis
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DataProcessor processor = new DataProcessor();
            processor.TestRedisConnection();
        }
    }
}
