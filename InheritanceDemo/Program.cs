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
            p.Id = 10;
            p.Name = "Johnan";
            p.Family = "Doe";
            Person p1 = new Person()
            {
                Id = 11,
                Name = "John",
                Family = "Doe"
            };
            Console.WriteLine(p.Equals(p1));
            Console.WriteLine(p.ToString());
            Console.WriteLine(p.GetType());
            Console.WriteLine(p.GetHashCode());
            Console.WriteLine("----------------------------");
            List<Person> people = new List<Person>();
            people.Add(new Person { Name = "Amirhossein", Family = "Olyanasab", Id = 101 });
            people.Add(new Person { Name = "Gucci", Family = "Bano", Id = 102 });
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }

            Console.WriteLine("***********************************");
            people.Remove(new Person { Name = "Neda", Family = "Maryami", Id = 102 });
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i]);
            }
            Console.ReadKey();
        }
    }
}
