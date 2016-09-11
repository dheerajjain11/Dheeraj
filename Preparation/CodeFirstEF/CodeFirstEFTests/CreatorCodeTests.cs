using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeFirstEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstEF.POCO;

namespace CodeFirstEF.Tests
{
    [TestClass()]
    public class CreatorCodeTests
    {
        [TestMethod()]
        public void CreateTest()
        {
            Society gayatriSociety = CreatorCode.Create("Gayatri");
            Assert.IsNotNull(gayatriSociety);
            
        }
    }
}