using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class Class3
    {
        /*static void Main()
        {
            string text = "Hello";

            Console.BackgroundColor = ConsoleColor.Blue;   // Փոխում է կոնսոլի գրված տողի գույնը

            Console.ResetColor();                          // Փոխված տողի գույնը վերադարձնում է default վիճակի

            Console.WriteLine(text);

            int frequency = 800;
            int duration = 500;
            //Console.Beep(frequency, duration);             // Տալիս է ձայնային ազդանշան, տալիս ենք հաճախականությունը (800hertz) ու տևողությունը (500 milliseconds)

            Console.BufferHeight = 1000;                    // Տալիս է կոնսոլի բարձրությունը
            Console.WriteLine(Console.BufferHeight);

            Console.BufferWidth = 3000;                    // Տալիս է կոնսոլի լայնությունը

            // Console.CancelKeyPress                      // ?

            Console.WriteLine(Console.CapsLock);           // Ստուգում է CapsLock-ը միացված է թե չէ

            //Console.Clear();                               // Մաքրում է նրանից առաջ գրված կոնսոլային ինֆորմացիան

            Console.CursorLeft = 0;                     // Կոնսոլի մեջ կուրսորը տանում է աջ, չի կարող մեծ լինել լայնությունից

            Console.CursorSize = 100;                   // Ցույց է տալիս թարթող կուրսորի չափը

            Console.CursorTop = 4;                      // Ցույց է տալիս կուրսորի հեռավորությունը վերևի տողից

            Console.CursorVisible = true;              // Ցույց է տալիս կոնսոլում կուրսորը լինի տեսանելի թե ոչ

            Console.WriteLine(Console.Equals(frequency, duration));     // Ցույց է տալիս կոնսոլում հավասար են նրա պարամետրերը թե ոչ

            Console.WriteLine(Console.Error);          // Ցույց է տալիս console application-ների համար input, output-ի և ստանդարտ error-ների ձևերը

            Console.ForegroundColor = ConsoleColor.White; // Տալիս է կոնսոլի ներքևի գրվածքի գույնը

            Console.WriteLine(Console.GetCursorPosition());   // Ցույց է տալիս կուրսորի դիրքը ձախից և վերևից

            // ? string str = Console.In;                    // Օգտագործվում է որպես input 

            string str1 = "Hello";
            Console.InputEncoding = Encoding.UTF8;        // Օգտագործվում է կոդավորումը փոխելու համար
            Console.WriteLine(str1);

            // ? Console.IsErrorRedirected();                 // Ստուգում է եթե output-ը error է տալիս վերադարձնում է true

            Console.WriteLine(Console.IsInputRedirected);     // Ստուգում է input-ը ստեղնաշարից է թե ուրիշ text file-ից

            Console.WriteLine(Console.IsOutputRedirected);    // Ստուգում է output-ը ունի ուրիշ հղման տեղ թե ոչ

            Console.ReadLine();
            Console.WriteLine(Console.KeyAvailable);          // Ցույց է տալիս input-ի ժամանակ ստեղնաշարի սեղմում կա թե ոչ 

            Console.WriteLine(Console.LargestWindowHeight);   // Տալիս է տվյալ ֆոնտի և էկրանի չափերի համար ամենամեծ հնարավոր կոնսոլի պատուհանի բարձրությունը

            Console.WriteLine(Console.LargestWindowWidth);    // Տալիս է տվյալ ֆոնտի և էկրանի չափերի համար ամենամեծ հնարավոր կոնսոլի պատուհանի լայնությունը

            Console.MoveBufferArea(10, 10, 10, 10, 10, 10);    // Buffer area-ն տեղափոխում է էկրանի տվյալ հատվածը

            Console.WriteLine(Console.NumberLock);            // Ցույց է տալիս NumLock-ը միացված է թե ոչ

            Console.WriteLine(Console.OpenStandardError());    // Ցույց է տալիս ստանդարտ error

            Console.OpenStandardInput();                       // Ստանում է ստանդարտ input-ի ուղղություն

            Console.OpenStandardOutput();                      // Ստանում է ստանդարտ output-ի ուղղություն

            // ? Console.Out();

            Console.OutputEncoding = Encoding.UTF8;            // Նշում կամ փոխում է տպելու համար օգտագործվող կոդավորումը

            Console.Read();                                    // Սպասում է input-ի

            Console.ReadKey();                                 // Չի փակում կոնսոլը մինչև մի հատ էլ ստեղն չսեղմվի

            Console.ReferenceEquals(frequency, duration);      // Համեմատում է 2 պարամետրերի ռեֆերանսները նույնն են թե ոչ

            Console.ResetColor();                              // Կոնսոլի ֆոնի և տառերի գույները սարքում է default ձևի

            Console.SetBufferSize(10000, 10000);               // Տալիս է buffer area-ի չափերը

            //Console.SetCursorPosition(0, 0);                   // Ցույց է տալիս թե որտեղ տեղադրի կուրսորը

            Console.WriteLine(Console.SetError);               // ?   Փոխում է TextWriter-ում error-ի նշանակությունը?

            Console.WriteLine(Console.SetIn);                  // ?

            Console.WriteLine(Console.SetOut);                 // ?

            //Console.SetWindowPosition(10, 10);                 // Տեղափոխում է կոնսոլի պատուհանը buffer area-ում

            //Console.SetWindowSize(10, 10);                     // Տալիօս ենք կոնսոլի պատուհանի չափսերը

            Console.Title = "Barlus Hayer";                    // ?  title-ը պետք է փոխի
            Console.WriteLine("Default Title: {0}",
                          Console.Title);

            Console.WriteLine(Console.TreatControlCAsInput);     // ?

            //Console.WindowLeft = 10;                         //  Տալիս ենք կոնսոլի windows-ի չափերը ամեն կողմից
            //Console.WindowTop = 10;
            //Console.WindowHeight = 10;
            //Console.WindowWidth = 10;    
        }*/
    }
}
