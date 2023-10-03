using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseWork
{
    class Program
    {
        public static void Main(string[] args)
        {
            TriangleFunction(); // for checking type of triangle
            //FibonacciFunction(); // for fibonacci
        }

        private static void TriangleFunction()
        {
            int sideA, sideB, sideC;

            System.Console.WriteLine("-------------------- TRIANGLE TYPE CHECKING --------------------");
            System.Console.Write("Input side 1 (number): ");
            sideA = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Input side 2 (number): ");
            sideB = Convert.ToInt32(Console.ReadLine());

            System.Console.Write("Input side 3 (number): ");
            sideC = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("");

            if (sideA == sideB && sideA == sideC && sideB == sideC)
            {
                Console.WriteLine("It's Equilateral Triangle");
            }
            else if(sideA == sideC || sideC == sideB || sideB == sideA)
            {
                Console.WriteLine("It's Isosceles Triangle");
            }
            else
            {
                Console.WriteLine("It's Scalene Triangle");
            }
        }

        private static void FibonacciFunction()
        {
            System.Console.WriteLine("-------------------- FIBONACCI --------------------");

            System.Console.Write("Input number: ");
            int numberInput = Convert.ToInt32(Console.ReadLine());

            var temp1 = 0;
            var temp2 = 1;

            System.Console.Write("The Fibonacci Result: ");
            for(int i = 0; i < numberInput; i++)
            {
                System.Console.Write("{0},", temp1);

                var count = temp1 + temp2;
                temp1 = temp2;
                temp2 = count;
            }
        }

        //sorry i only can answer 2 numbers, because this is my first time using c# and .net
    }
}
