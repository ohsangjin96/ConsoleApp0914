using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp0914
{
   
    class cat
    {
        public string name;
        public string color;
        public int age;
        public cat(string _name,String _color)
        {
            name = _name;
            color = _color;
        }
        public cat(int _age)
        {
            age = _age;
        }
       
        public void Sound()
        {
            Console.WriteLine($"{color}색 {name} 고양이가 야~~옹");
        }
        public void Scratch()
        {
            Console.WriteLine("찍");
        }
        
        public void Eat()
        {
            Console.WriteLine("사료를 먹는다");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            cat c1 = new cat("로지","black");

            c1.Sound();
        }

        
    }
}
