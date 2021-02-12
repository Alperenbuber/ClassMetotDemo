using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Student : IPerson
    {
        public string Id { get; set; }
        public string Adı { get; set; }

        public void Add()
        {
            Console.WriteLine("Öğrenci eklenmiştir: ");
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

