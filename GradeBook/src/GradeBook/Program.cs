using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
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

        }
    }
}
