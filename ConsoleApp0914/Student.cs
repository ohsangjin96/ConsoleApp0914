using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0914
{
    class Student
    {
        string name;
        int age;
        
        double weight;

        private double height;
        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 50)
                    height = value;
            }
        }
    }
    class ProgramText
    {
        static void Main()
        {

            Student stu1 = new Student();
            stu1.Height = -150;
            Console.WriteLine(stu1.Height);

            stu1.Height = 185.5;
            Console.WriteLine(stu1.Height);
        }
    }
}
