using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========Welcome To User Registration===========");
            //Creating object od class
            Registration registration = new Registration();
            registration.FirstName();
            registration.LastName();
            Console.ReadKey();

           
            
        }

    }
}
