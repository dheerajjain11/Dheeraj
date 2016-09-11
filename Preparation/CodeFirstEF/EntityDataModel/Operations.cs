using CodeFirstEF.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityDataModel
{
    public class Operations
    {
        public void AddSociety(Society society)
        {
            using (CodeFirstSocietyModel context = new CodeFirstSocietyModel())
            {
                context.Societies.Add(society);
                context.SaveChanges();
            }
        }

        public Society GetSocietyByName(string name)
        {
            using (CodeFirstSocietyModel context = new CodeFirstSocietyModel())
            {
                return context.Societies.Where(x => x.Name.Equals(name)).FirstOrDefault<Society>();
            }
        }
    }
}
