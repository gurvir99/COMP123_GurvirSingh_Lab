using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_GurvirSingh_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Person harry = new Person("Harry", 34);
            harry.SaysHello();
            Console.WriteLine(harry.ToString());
            Console.WriteLine();

            Person john = new Person("John", 22);
            john.SaysHello();
            Console.WriteLine(john.ToString());
            Console.WriteLine();

            Student mike = new Student("Mike", 19, "DHGFH466F");
            mike.SaysHello();
            mike.Studies();
            Console.WriteLine(mike.ToString());
            Console.WriteLine();
           
            Teacher t1 = new Teacher("Ben", 40, "A237CGW7DDX");
            t1.SaysHello();
            t1.Teaches();
            Console.WriteLine(t1.ToString());
            Console.WriteLine();



            internationalStudent i1 = new internationalStudent("Bill", 21, "BCV434893", "34 Lawrence Street, London (England)");
            i1.SaysHello();
            i1.Studies();
            i1.IsInternational();
            Console.WriteLine(i1.ToString());
            Console.WriteLine();
        }
    }
}
