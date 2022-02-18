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

            int a1 = string.Compare(str1, str2);  //    Համեմատումա str1 ու str2-ը, եթե այբբենական կարգով str1-ը 
            Console.WriteLine(a1);                // ավելի բարձրա str2-ից, ապա վերադարձնումա 0-ից փոքր թիվ, եթե չէ հակառակը

            int a2 = string.CompareOrdinal(str1, str2);
            Console.WriteLine(a2);               //    Համեմատումա 2 str-ների char-երի թվերի գումարը, եթե 1-ինը փոքրա 2-ից
                                                 // վերադարձնումա բացասական թիվ, եթե չէ՝ դրական

            string a3 = string.Concat(str1, str2);   // Միավորում է 2 str-ները
            Console.WriteLine(a3);

            string a4 = string.Empty;           //    Սա read only է, սրանով կարող ենք նշել օրինակ դատարկ տողը,
                                                //  այն չի օգտագործվում որպես մեթոդ

            bool a5 = string.Equals(str1, str2);   // Համեմատում է արդյոք 2 str-ները հավասար են
            Console.WriteLine(a5);

            int b = 5;
            string a6 = string.Format("{0}, {1}", str1, 5);   // Օգնում է փոխակերպել string format-ի շատ հեշտ
            Console.WriteLine(a6);

            int a7 = string.GetHashCode(str1);       // Վերադարձնում է string-ի մեջի տեքստի Hash code-ը
            int a7_1 = string.GetHashCode(str2);
            Console.WriteLine(a7);
            Console.WriteLine(a7_1);

            string a8 = string.Intern(str1);      // Այս միջոցով պահվում է ցանկացած string-ի 1 կոպիա
            Console.WriteLine(a8);

            string? a9 = string.IsInterned(str2);   // Վերադարձնում է տվյալ string-ի ռեֆերենսը
            Console.WriteLine(a9);

            bool a10 = string.IsNullOrEmpty(str1);  // Ստուգում է տվյալ string-ը դատարկ է թե ոչ
            Console.WriteLine(a10);

            bool a11 = string.IsNullOrWhiteSpace(str2);  // Ստուգում է տվյալ string-ը դատարկ է կամ ընդունում է \t, \n
            Console.WriteLine(a11);

            string a12 = string.Join(str1, str2);  // ?
            Console.WriteLine(a12);

            bool a13 = string.ReferenceEquals(str1, str2); // Ստուգում է արդյոք ռեֆերենսները հավասար են
            Console.WriteLine(a13);
        }
    }
}
