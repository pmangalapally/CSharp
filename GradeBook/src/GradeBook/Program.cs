using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Pavan's Book");
            book.AddGrades(99.99);
            book.AddGrades(52.7);
            book.AddGrades(79.81);

            book.ShowStatistics();
            
             /* 
            double[] numbers = new double[3] {11.2, 12.3, 14.5};
            var result = 0.0;
            foreach (double number in numbers)
            {
                result += number;
            }
            Console.WriteLine($"Sum of grades is {result}");

            List<double> NewNumbers = new List<double>();
            NewNumbers.Add(39.6);
            NewNumbers.Add(67.89);
            NewNumbers.Add(98.9);
            var newresult = 0.0;
            
            foreach(double ListObj in NewNumbers)
            {
                newresult += ListObj;

            }

            Console.WriteLine($"New List Total is {newresult}");

           Commented after successful testing
            var UserName = "Pavan Kumar";
            Console.WriteLine("Hello World!");
            Console.WriteLine($"Hello World!");
            Console.WriteLine ("Hello " + UserName + "!");
            Console.WriteLine ($"Hello {UserName}!");
            
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine ("No argulemnts found");
            }
            */

        }
    }
}
