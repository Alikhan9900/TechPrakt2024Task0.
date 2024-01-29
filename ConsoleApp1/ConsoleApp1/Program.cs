using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть перше число:");
            string input1 = Console.ReadLine();

            Console.WriteLine("Введіть друге число:");
            string input2 = Console.ReadLine();

            if (double.TryParse(input1, out double number1) && double.TryParse(input2, out double number2))
            {
                double sum = number1 + number2;
                Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");
            }
            else
            {
                Console.WriteLine("Помилка введення. Будь ласка, введіть коректні числа.");
            }

            Console.ReadLine();
        }
    }
}
