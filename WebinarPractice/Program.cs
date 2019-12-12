using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository _techRepo = new TechRepository();
            IRepository _mgmtRepo = new ManagerRepository();

            _techRepo.ReadData();
            _mgmtRepo.managerChanged += _techRepo.ChangeManager;
        }
    }
}
