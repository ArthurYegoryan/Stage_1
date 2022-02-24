using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class Array_Commands
    {
        /*static void Main()
        {
            // Բացի generic command-ներից, մնացածը ներառված են
            
            string[] names = { "Arthur", "Armen", "Karen", "Vardan" };

            
            string[] names1 = {"0", "0", "0", "0" };
            Array.Copy(names, names1, names.Length);    // Ստեղծում է names array-ի copy-ն names1 array-ում
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }
            Console.WriteLine();

            
            Array.AsReadOnly(names);                    // names array-ի էլեմենտները դարձնում է readonly, այսինքն չենք կարող փոփոխել
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
            
            
            Console.WriteLine(Array.BinarySearch(names, "Armen"));    // Փնտրում է names array-ի մեջ տրված էլեմենտը և վերադարձնում նրա index-ը

            
            Array.Clear(names1);                          // Ջնջում է names1 array-ի մեջի եղած info-ն
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names1[i]);
            }

            
            string[] names2 = new string[] { "0", "0" };       // names array-ից որոշակի էլեմենտների մաս copy է անում names2 array-ի մեջ
            Array.ConstrainedCopy(names, 1, names2, 0, 2);
            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            
            string[] names3 = new[] { "1", "2", "3", "4", "5" };
            Array.ConvertAll<string, int>(names3, Convert.ToInt32);      // Convert է անում names3-ի էլեմենտները այլ ֆորմատի
            foreach (string number in names3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            
            Array.CreateInstance(typeof(string), names3.Length);   // Ստեղծում է arrays,որոնց type-երը հայտնի են դառնում run անելու ժամանակ
            foreach (string number in names3)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            
            Array.Empty<string>();      // Վերադարձնում է string տիպի դատարկ array

            
            Console.WriteLine(Array.Equals(names, names3));   // Վերադարձնում է արդյոք տրված 2 array-ները հավասար են թե ոչ


            Console.WriteLine(Array.IndexOf(names3, "2"));   // Վերադարձնում է տրված array-ում, տրված արժեքով 1-ին հանդիպած էլեմենտի ինդեքսը


            string[] names4 = new[] { "1", "2", "3", "4", "2" };
            Console.WriteLine(Array.LastIndexOf(names4, "2"));      // Վերադարձնում է տրված array-ում, տրված արժեքով վերջին հանդիպած էլեմենտի ինդեքսը


            int maxLength = Array.MaxLength;         // Վերադարձնում է էլեմենտների մաքսիմում քանակը, որ կարող է պարունակվել array-ի մեջ
            Console.WriteLine(maxLength);


            bool is_ref_equal = Array.ReferenceEquals(names, names4);    // Վերադարձնում է արդյոք հավասար են տրված 2 array-ների reference-ները
            Console.WriteLine(is_ref_equal);
            Console.WriteLine();


            Array.Reverse(names4);              // Վերադարձնում է տրված array-ի հակադարձ տեսքը
            foreach (string item in names4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            int[] numbers = new int[] { 7, 2, 10, 5, 4, 8 };
            Array.Sort(numbers);                                    // Սորտավորւմ է array-ը ըստ աճման կարգի
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }                    

            Console.ReadKey();
        }*/
    }
}
