using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Lesson_8_Classes_Structs
{
    class Gun                                                  //     Ինկապսուլացիան այն է, որ class-ից պետք է դոստուպ տալ միայն այն օբյեկտներին,
    {                                                          //  որոնցից օգտվում ենք (սխալներից խուսափելու համար)
        private bool isLoaded;                                 //  Կազմակերպում ենք access modifier-ների օգնությամբ

        private void Reload()
        {
            Console.WriteLine("Reloading...");

            isLoaded = true;

            Console.WriteLine("Reloaded!");
        }

        public void Shot()
        {
            if (isLoaded == false)
            {
                Console.WriteLine("Gun isn't reloaded!");
                Reload();
            }
            Console.WriteLine("Ddsh-ddsh!!!");
            isLoaded = false;
        }
    }
    internal class _8_Lesson_Encapsulation
    {
        static void Main()
        {
            Gun gun = new Gun();
            gun.Shot();
        }
    }
}
