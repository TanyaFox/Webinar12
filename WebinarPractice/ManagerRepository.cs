using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public class ManagerRepository : IRepository
    {
        public Action<Manager> managerChanged;

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

        public void ChangeManager(Manager previousManager, Manager currentManager)
        {
            currentManager.Team = new List<Person>();

            foreach (var person in previousManager.Team)
            {
                currentManager.Team.Add(person);
            }

            managerChanged?.Invoke(currentManager);
        }
    }
}
