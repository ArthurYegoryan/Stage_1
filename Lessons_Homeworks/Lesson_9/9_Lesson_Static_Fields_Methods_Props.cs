using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Lessons_Homeworks.Lesson_9
{
    class MyClass
    {
        public int a;

        public static int b;             // static նշանակում է, որ անդամի հետ կարող են շփվել class-ի անդամները, բայց class-ից դուրս
                                         // նրա վրա դոստուպ կարող են ունենալ միայն class-ի մակարդակով, ոչ թե instance-ով
    }

    class Methods
    {
        private static int c;        // c-ի վրա դոստուպ ունեն class-ի անդամները, բայց դրսից չունենք, նույնիստ class-ի մակարդակով

        private int d = 5;       

        private static int e;

        public static int MyProperty
        {
            get { return e; }
            set { e = value; }
        }


        public static void SetX()
        {
            c = 7;
            //d = 5;       // Error    // static method-ի ներսում չենք կարող շփվել ոչ static անդամների հետ 
        }
        public void GetX()
        {
            Console.WriteLine(c);
            Console.WriteLine(d);      // Ոչ static method-ով կարող ենք շփվել և static, և ոչ static անդամների հետ
        }
    }
    internal class _9_Lesson_Static_Fields_Methods_Props
    {
        static void Main()
        {
            MyClass myClass = new MyClass();
            myClass.a = 5;                        // Instance-ով դոստուպ ունենք MyClass-ի a field-ի վրա

            //myClass.b = 6;       // Error       // Instance-ով չենք կարող դոստուպ ունենալ MyClass-ի b-ին

            MyClass.b = 6;                        // b-ին կարող ենք արժեք տալ MyClass-ով (class-ի մակարդակով)
            MyClass.b = 7;                        // և եթե հետո փոխենք, ապա փոխվելու է նույն b-ի արժեքը
            Console.WriteLine(MyClass.b);

            MyClass myClass1 = new MyClass();
            MyClass myClass2 = new MyClass();

            myClass1.a = 8;
            myClass2.a = 9;

            Console.WriteLine(myClass1.a);        // Instance-ները հիշողության մեջ զբաղեցնում են առանձին տեղեր և եթե դրանցից մեկը
            Console.WriteLine(myClass2.a);        // մի field-ի վրա փոփոխություն է անում, ապա դա չի ազդում մյուս instance-ի արած
                                                  // փոփոխության վրա
        
            Methods methods = new Methods();

            //methods.SetX();      // Error       // Instance-եվ դոստուպ չունենք SetX() method-ի վրա, քանի որ ստստիկ է

            Methods.SetX();                       // SetX() method-ի վրա դոստուպ ունենք class-ի մակարդակով

            methods.GetX();                       // GetX() method-ի վրա դոստուպ ունենք instance-ով

            //methods.MyProperty   // Error       // Եթե Property-ները static են, ապա, instance-ով դոստուպ չունենք

            Methods.MyProperty = 5;               // static property-ների հետ կարող ենք շփվել class-ի մակարդակով
            int x = Methods.MyProperty;
            Console.WriteLine(x);
        }      
    }
}
*/