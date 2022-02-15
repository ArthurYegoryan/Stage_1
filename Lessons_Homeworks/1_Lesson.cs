using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myWorks
{
    internal class Lesson_1
    {
        static void Main()
        {
            Console.WriteLine("Hello World");

            Console.Write("What is your name?  ");
            var name = Console.ReadLine();

            Console.WriteLine($"Hello {name}!");

            Console.WriteLine("How old are you?");
            var age_str = Console.Readline();
            int age = convert.Toint(age_str);
            Console.WriteLine($"I am {age}");

            Console.ReadKey();
        }
    }
}
