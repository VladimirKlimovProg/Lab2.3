using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Введите натуральное число больше 1");

            try
            {
                number = int.Parse(Console.ReadLine());
                if (number <= 1)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Не натуральное число или число, равное 1");
                return;
            }

            bool isNumberPrime = true;

            for (int i = 2; i * i <= number; i = 2 * i - 1)
            {
                if (number % i == 0)
                {
                    isNumberPrime = false;
                    break;
                }
            }
            
            if (isNumberPrime)
            {
                Console.WriteLine($"Число {number} простое");
            }
            else
            {
                Console.WriteLine($"Число {number} не простое");
            }
        }
    }
}
