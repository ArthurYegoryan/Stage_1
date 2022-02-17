using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class Class2
    {
        static void Main()
        {
            string str1 = "Hello";
            string str2 = "World";

            Console.WriteLine(str1 + " " + str2 + "!");

            int a = string.Compare(str1, str2);  //    Համեմատումա str1 ու str2-ը, եթե այբբենական կարգով str1-ը 
            Console.WriteLine(a);                // ավելի բարձրա str2-ից, ապա վերադարձնումա 0-ից փոքր թիվ, եթե չէ հակառակը
            

        }
    }
}
