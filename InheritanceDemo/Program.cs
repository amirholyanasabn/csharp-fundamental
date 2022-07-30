using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Name = "John";
            p.Family = "Doe";
            Console.WriteLine(p.Equals(p));
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.ReadKey();
        }
    }
}
