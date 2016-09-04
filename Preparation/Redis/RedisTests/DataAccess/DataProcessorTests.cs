using Microsoft.VisualStudio.TestTools.UnitTesting;
using Redis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Redis.DataAccess;

namespace Redis.DataAccess.Tests
{
    [TestClass()]
    public class DataProcessorTests
    {
        [TestMethod()]
        public void TestRedisConnectionTest()
        {
            DataProcessor processor = new DataProcessor();
            Assert.IsTrue(processor.TestRedisConnection());
        }
    }
}