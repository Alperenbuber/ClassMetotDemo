using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Customer : IPerson
    {
        public string Id { get; set; }
        public string Adı { get; set; }

        public void Add()
        {
            Console.WriteLine("Müşteri eklenmiştir: ");
        }

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Deleted()
        {
            throw new NotImplementedException();
        }
    }
}
