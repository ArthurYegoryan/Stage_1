using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks.Lesson_9
{
    class MyClass
    {
        public int a;
        static int b;
        
        public MyClass()
        {
            Console.WriteLine("Constructor");
        }
        
        public MyClass(int a)
        {
            Console.WriteLine("Constructor");
            Console.WriteLine(a);            
        }

        static MyClass()                              // Class-ը կարող է ունենալ միայն 1 static constructor և այն ռեալիզացվում է class-ի 
        {                                             // օգտագործման ամենասկզբում, այն չի կարող ստանալ պարամետրեր
            Console.WriteLine("Static constructor");

            //a = 5;                                  // Ինչպես static methodner-ում static constructor-ում նույնպես չենք կարող շփվել
            // ոչ static անդամների հետ

            b = 7;                                    // Իսկ static անդամների հետ խնդիր չկա
        }

        public static void Foo()
        {
            Console.WriteLine("Foo");
        }
    }
    internal class _9_Lesson_Static_Constructors
    {
        static void Main()
        {
            //MyClass myClass = new MyClass(6);
            //new MyClass();                            // Քանի որ instance-ը չենք օգտագործելու պարզապես կանչում ենք class-ը

            MyClass.Foo();                    // Եթե class-ից կանչենք միայն Foo-ն, ապա կտեսնենք, որ նախ աշխատում է static constructor-ը,
                                              // ապա նոր Foo()-ն

            // Static constructor-ի առավելությունը այն է, որ օրինակ ունենք DB և նրանից պետք է օգտվենք շատ անդամներից,
            // ապա եթե ամեն անգամ կանչենք սովորական constructor, կունենանք ավելորդ հիշողության կորուստ, որը լավ չէ
            // դրա համար օգտագործում ենք static constructor, որը կկանչվի միայն մեկ անգամ և կապահովի բոլոր անդամների օգտագործումը
        }
    }
}
