using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0914
{

    //메서드시그니처-메서드명,파라미터 갯수,파라미터 타입(반환타입은
    class Mymath
    {
        public int x;
        public int y;

        public Mymath()
        {
            Console.WriteLine("생성자 호출");
            x = 10;
            y = 10;
        }
        public Mymath(int a, int b)
        {
            x = a;
            y = b;
        }
        public int Plus(int x, int y)
        {
            int result = x + y;
            return result;
        }
        public int Minus(int a, int b)
        {
            int result = a - b;
            return result;
        }
        public int Mul(int a, int b)
        {
            int result = a * b;
            return result;
        }
        public double Div(double a, double b)
        {
            double result = a / b;
            return result;
        }
    }
    class Class2
    {
        static void Main()
        {
            Mymath m1 = new Mymath();
            //변수값을 초기화할때 사용함
            int sum = m1.Plus(30,50);
            Console.WriteLine(sum);



        }

    }
}