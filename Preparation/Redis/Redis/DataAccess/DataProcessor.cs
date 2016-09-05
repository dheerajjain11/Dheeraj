using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

using Redis.Common;

namespace Redis.DataAccess
{
    public class DataProcessor
    {
        static readonly string RedisConnectionString = ConfigurationManager.ConnectionStrings["Redis"].ToString();
        public void InsertAll(ParticipantAnnualReportKeyDataPoints[] dataArray)
        {
            using (ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect(RedisConnectionString))
            {
                IDatabase cache = redisConnection.GetDatabase();

                //insert in first million rows
                for (int i = 0; i < dataArray.Length; i++)
                {
                    cache.StringSetBitAsync(dataArray[i].PersonID.ToString(), 0, dataArray[i].IsDeceased);
                }
                //insert in next million rows
                for (int i = 0; i < dataArray.Length; i++)
                {
                    cache.StringSetBitAsync(dataArray[i].PersonID.ToString(), 1000000, dataArray[i].IsExpat);
                }
                //insert in next million rows
                for (int i = 0; i < dataArray.Length; i++)
                {
                    cache.StringSetBitAsync(dataArray[i].PersonID.ToString(), 2000000, dataArray[i].IsTerminated);
                }
                //insert in next million rows
                for (int i = 0; i < dataArray.Length; i++)
                {
                    cache.StringSetBitAsync(dataArray[i].PersonID.ToString(), 3000000, dataArray[i].IsWait);
                }

            }
        }

        public bool TestRedisConnection()
        {
            try
            {
                using (ConnectionMultiplexer redisConnection = ConnectionMultiplexer.Connect(RedisConnectionString))
                {
                    IDatabase cache = redisConnection.GetDatabase();  
                    cache.StringSet("Hello", "World");
                    string key = cache.StringGet("Hello");
                    if (key.Equals("World"))
                        return true;
                    else
                        return false;   
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace);
                return false;
            }
        }

    }
}
