using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    class AgePeople
    {
        private int age;                          // get, set-ով կարողանում ենք դոստուպ ունենալ class-ի private անդամների վրա
                                                  // prop + 2xtab ձևով միանգամից սարքում ենք get, set-ի կոմպակտ կառուցվածքը
        public int Age { get; set; }

        private int ageRange;                     // Նաև կարող ենք ավելացնել հավելյալ լոգիկա class-ի մեջ, որը կվերաբերի private անդամին
                                                  // propfull + 2xtab ձևով միանգամից սարքում ենք get, set-ի լրիվ կառուցվածքը
        public int MyProperty
        {
            get { return ageRange; }
            set { ageRange = value; }
        }

    }
    internal class _9_Lesson_Get_Set
    {
        static void Main()
        {
            AgePeople agePeople = new AgePeople();

            Console.Write("Enter your age: ");
            agePeople.Age = Convert.ToInt32(Console.ReadLine());

            int age = agePeople.Age;

            if (age < 20)
            {
                Console.WriteLine("Sorry, you can't do it, you are small yet!");
                return;
            }
            else if (age > 50)
            {
                Console.WriteLine("Sorry, you can't do it, you are old enough!");
                return;
            }

            Console.WriteLine("Nice, you can do it!");
        }
    }
}
