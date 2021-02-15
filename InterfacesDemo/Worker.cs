using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Worker : IWorkerManager, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
