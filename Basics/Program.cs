using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1 FizzBuzz
            int number;
            number = int.Parse(Console.ReadLine());
            if (number < 1 || number > 100)
                throw new Exception("Wrong diapazon");

            if (number % 3 == 0)
                Console.WriteLine("Fizz");

            if (number % 5 == 0)
                Console.WriteLine("Buzz");

            if (number % 5 != 0 && number % 3 != 0)
                Console.WriteLine(number);
            */

            /* 2 Percent
            Console.WriteLine("Введите число");
            uint num = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите процент");
            uint percent = uint.Parse(Console.ReadLine());
            double result = num / 100.0 * percent;
            Console.WriteLine(result);
            */

            /* 3 Create num
            int result = 0;
            for (int i = 0; i < 4; ++i)
            {
                Console.WriteLine("Введите цифру");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                result *= 10;
                result += num;
            }
            Console.WriteLine(result);
            
            */

            /* 4 Swap digit
            int number = int.Parse(Console.ReadLine());
            if (number < 100000 || number > 999999)
                throw new Exception("Wrong number");

            int razrad_1 = int.Parse(Console.ReadLine());
            int razrad_2 = int.Parse(Console.ReadLine());

            int cifra_1 = (number / (int)Math.Pow(10, razrad_1 - 1)) % 10;
            int cifra_2 = (number / (int)Math.Pow(10, razrad_2 - 1)) % 10;

            number += - cifra_1 * (int)Math.Pow(10, razrad_1 - 1) + cifra_2 * (int)Math.Pow(10, razrad_1 - 1);
            number += - cifra_2 * (int)Math.Pow(10, razrad_2 - 1) + cifra_1 * (int)Math.Pow(10, razrad_2 - 1);

            Console.WriteLine(number);
            */

            /* 6 F-C converter
            int temperature = int.Parse(Console.ReadLine());
            char choice = char.Parse(Console.ReadLine());
            if (choice == 'F')
                Console.WriteLine(temperature * (9 / 5.0) + 32);
            else if (choice == 'C')
                Console.WriteLine((temperature - 32) * (5 / 9.0));
            else
                throw new Exception("Unknow symbol");
            */

            /* 7 Even numbers
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            for (int i = Math.Min(firstNum, secondNum); i <= Math.Max(firstNum, secondNum); ++i)
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }
            */

        }
    }
}
