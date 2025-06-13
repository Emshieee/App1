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

        // iremove yung parehong letters tapos makikita count remaining
        static int GetRemainingLettersCount(string name1, string name2)
        {
            string cleanedName1 = CleanName(name1);
            string cleanedName2 = CleanName(name2);

            var name1Chars = new StringBuilder(cleanedName1);
            var name2Chars = new StringBuilder(cleanedName2);

            for (int i = 0; i < name1Chars.Length; i++)
            {
                char c = name1Chars[i];
                int index = name2Chars.ToString().IndexOf(c);
                if (index != -1)
                {
                    name1Chars[i] = '*'; // mark as removed
                    name2Chars[index] = '*';
                }
            }

            int count = 0;
            foreach (char c in name1Chars.ToString())
                if (c != '*') count++;
            foreach (char c in name2Chars.ToString())
                if (c != '*') count++;

            return count;
        }

    }
}