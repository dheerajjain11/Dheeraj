using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstEF.POCO
{ 
    public abstract class ResidentialUnit
    {
        public Guid ID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
    }
}
