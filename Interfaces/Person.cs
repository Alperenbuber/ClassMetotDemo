using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface IPerson
    {
         string Id { get; set; }
         string Adı { get; set; }


        void Add();
        void BiseyYap();
        void Deleted();

    }
}
