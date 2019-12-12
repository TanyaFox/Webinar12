using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebinarPractice
{
    public interface IRepository
    {
        void ReadData();
        void AddItem();
        void DeleteItem();
    }
}
