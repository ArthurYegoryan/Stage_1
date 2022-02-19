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

            Console.Write("How old are you?  ");
            var age_str = Console.ReadLine();
            int age = Convert.ToInt32(age_str);
            Console.WriteLine($"Arthur is {age} years old");

            Console.ReadKey();
        }
    }
}
