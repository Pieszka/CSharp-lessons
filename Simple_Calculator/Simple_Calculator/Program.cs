using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)

        {
            float first_number, second_number;
            char action;

            Console.WriteLine("Whis is a simple calculator. You can write two numbers and plus, substract, multiply or divide it");
            Console.WriteLine("Please write first number");
            first_number = float.Parse(Console.ReadLine());
            Console.WriteLine("Okey, now choose one of these signs: + (add), - (substract), *(multiply), / (divide)");
            action = char.Parse(Console.ReadLine());
            Console.WriteLine("Now you can choose second number");
            second_number = float.Parse(Console.ReadLine());

            if (action == '+') 
            {
                float sum;
                sum = first_number + second_number;
                Console.WriteLine(sum + " - this is your result");
            }
            if (action == '-')
            {
                float sum;
                sum = first_number - second_number;
                Console.WriteLine(sum + " - this is your result");
            }
            if (action == '*')
            {
                float sum;
                sum = first_number * second_number;
                Console.WriteLine(sum + " - this is your result");
            }
            if (action == '/')
            {
                float sum;
                sum = first_number / second_number;
                Console.WriteLine(sum + " - this is your result");
            }

            Console.ReadKey();
        }
    }
}
