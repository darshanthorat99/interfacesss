using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static interfacesss.Emp;

namespace interfacesss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp(1, "vishal", 200000);
            Console.WriteLine( e1.Print());

            Student s1 = new Student(24, "rahul",70.24);
            Console.WriteLine( s1.Print());


            ICustomer I = new Transaction(1, 25, 5000, 10, "darshan", 9420892285);
            Console.WriteLine(I.Detail());
            IOrder O = new Transaction(1,25,5000,10,"darshan",9420892285);
            Console.WriteLine(O.Detail());

        }
    }
}
