using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0914
{
    class Class3
    {
        static void Main()
        {
            Console.WriteLine("person 객체 생성되기 전.");
            Person p1 = new Person("손흥민");

            Console.WriteLine("");
            
           

            Console.WriteLine("person 객체 생성된 후.");
        }
        
    }
    public class Person
    {
        string name;
      
        public Person(string _name)
        {
            name = _name;
          
        }
    }
}
