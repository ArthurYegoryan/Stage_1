using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Lessons_Homeworks.Lesson_8_Classes_Structs
{
    class Gun                                                  
    {                                                          
        public Gun(bool isLoaded)                             //   ctor ու 2 tab-ով ստեղծում ենք constructor
        {                                                     //  constructor-ի մեջից կարեղ ենք private արժեքները փոխել
            _isLoaded = isLoaded;                             //  և ստեղծված instance-ները արդեն կընդունեն constructor-ի փոխած արժեքները  
        }                                                     //     Constructor-ի շնորհիվ չենք կորցնում ինկապսուլյացիայի իմաստը
        
        private bool _isLoaded;                                 

        private void Reload()
        {
            Console.WriteLine("Reloading...");                  //     Ինկապսուլյացիան այն է, որ class-ից պետք է դոստուպ տալ միայն այն օբյեկտներին,
                                                                //  որոնցից օգտվում ենք (սխալներից խուսափելու համար)
            _isLoaded = true;                                   //  Կազմակերպում ենք access modifier-ների օգնությամբ

            Console.WriteLine("Reloaded!");
        }

        public void Shot()
        {
            if (_isLoaded == false)
            {
                Console.WriteLine("Gun isn't reloaded!");
                Reload();
            }
            Console.WriteLine("Ddsh-ddsh!!!");
            _isLoaded = false;
        }
    }
    internal class _8_Lesson_Encapsulation
    {
        static void Main()
        {
            Gun gun = new Gun(isLoaded: true);  //  կամ  Gun(true)       //  Կարող ենք պարամետրով տալ constructor-ի արժեքը, եթե տալիս ենք true, ուրեմն լիցքավորված է և
            gun.Shot();                                                  // միանգամից կրակում է, եթե տալիս ենք false, ուրեմն լիցքավորում է նոր է կրակում
        }
    }
}*/
