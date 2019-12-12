using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    class TechRepository : IRepository
    {
        public List<TechnicalSpecialist> TechSpecialists { get; set; }

        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public void DeleteItem()
        {
            throw new NotImplementedException();
        }

        public void ReadData()
        {
            throw new NotImplementedException();
        }

        public void ChangeManager(Manager manager)
        {

        }
    }
}
