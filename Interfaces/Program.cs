using System;

namespace Interfaces
{
    class Program

    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Adı = "Ali";
            customer.Id = "123";
            customer.Add();


            Student student = new Student();
            student.Adı = "Alperen";
            student.Id = "1234";
            student.Add();


            Console.WriteLine("Öğrenci başarıyla eklenmiştir:" + student.Adı);
            Console.WriteLine("Customer başarıyla eklenmiştir:" + customer.Adı);


        }
        
    }
}
