using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_objects.Company_project
{
    class Program
    {
        static void Main(string[] args)
        {
            int employers_number;
            int[] tablica = new int[100];
           
            


            Console.WriteLine("Welcome to Coderation Company system. As an admin you have ability to enter some data");
            Console.WriteLine("Pic a number od empleyers working at Coderation. You can enter max. 100.");
            employers_number = int.Parse(Console.ReadLine());
            Console.WriteLine("Below, there is a blank list of employers");
            
            for (int x = 1; x<= employers_number; x++)

            {
                Console.WriteLine(x + ". Name, Surname, Status, Salary.");
            }

            Console.ReadKey();
        }
    }
}
