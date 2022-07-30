using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public override bool Equals(object obj)
        {
            if (this.Name == (obj as Person).Name && this.Family == ((Person)obj).Family )
                return true;
            return false;
           // return this.GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.Id;
        }
        public override string ToString()
        {
            return $"{Id} - {Name} - {Family}";
        }
    }
}
