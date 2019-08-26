using System.Collections.Generic;
using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
            List<double> list = new List<double>();
            Math math = new Math();
            char oper;
            Console.Write("Enter the operation( + - * / ): ");
            oper = Convert.ToChar(Console.ReadLine());
            double[] Arr = Array();
            list.AddRange(Arr);
            switch (oper)
            {
                case '+':
                    Console.WriteLine(math.Summary(Arr));
                    break;
                case '-':
                    Console.WriteLine(math.Substract(Arr));
                    break;
                case '*':
                    Console.WriteLine(math.Multiply(Arr));
                    break;
                case '/':
                    Console.WriteLine(math.Division(Arr));
                    break;
                default:
                    Console.WriteLine("Not correct format");
                    break;
            }



        }
        public static double[] Array()
        {
            double[] arr = new double[2];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter {0} number: ", i + 1, arr[i]);
                arr[i] = Convert.ToDouble(Console.ReadLine());
            }
            return arr;
        }
    }
    class Math
    {
        public double sum;
        public double Summary(double[] numbers)
        {
            sum = 0;
            foreach (double i in numbers)
            {
                sum += i;
            }
            for (int j = 0; j <= numbers.Length; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            return sum;
        }
        public double Substract(double[] numbers)
        {
            sum = numbers[0];
            foreach (double i in numbers)
            {
                if (i == numbers[0])
                {
                    continue;
                }
                sum -= i;
            }
            for (int j = 0; j <= numbers.Length; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            return sum;
        }
        public double Multiply(double[] numbers)
        {
            sum = 1;
            foreach (double i in numbers)
            {
                sum *= i;
            }
            for (int j = 0; j <= numbers.Length; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            return sum;
        }
        public double Division(double[] numbers)
        {
            sum = numbers[0];
            foreach (double i in numbers)
            {
                if (i == numbers[0])
                {
                    continue;
                }
                sum /= i;
            }
            for (int j = 0; j <= numbers.Length; j++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            return sum;
        }
    }
}
