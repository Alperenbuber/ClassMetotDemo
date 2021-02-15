using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorkerManager[] workerManagers = new IWorkerManager[3]
                        {
                new Manager(),
                new Robot (),
                new Worker(),

                        };
            _ = workerManagers;

        }


    }
}
