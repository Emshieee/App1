using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FLAMES Relationship Calculator ===");
            Console.Write("Enter your name: ");
            string name1 = Console.ReadLine();

            Console.Write("Enter the other person's name: ");
            string name2 = Console.ReadLine();

            int count = GetRemainingLettersCount(name1, name2);
            string result = GetFlamesResult(count);

            Console.WriteLine($"\nResult: {result}");
            Console.ReadLine();
        }

        //dito yung clean name 
        static string CleanName(string name)
        {
            return name.ToLower().Replace(" ", "").Trim();
        }
    }
}