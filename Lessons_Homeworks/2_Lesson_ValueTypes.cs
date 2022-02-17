using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_Homeworks
{
    internal class Class1
    {
        static void Main()
        {
            Console.WriteLine("Byte operations:");
            
            byte a = 15;
            byte b = 20;
            
            byte sumByte1 = Convert.ToByte(a + b);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumByte1));
            Console.WriteLine("Sum = " + sumByte1);

            int sumByte2 = a + b;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumByte2));
            Console.WriteLine("Sum = " + sumByte2);

            int subByte1 = a - b;
            Console.WriteLine("Type is " + Convert.GetTypeCode(subByte1));
            Console.WriteLine("Subtraction = " + subByte1);

            sbyte subByte2 = Convert.ToSByte(a - b);
            Console.WriteLine("Type is " + Convert.GetTypeCode(subByte2));
            Console.WriteLine("Subtraction = " + subByte2);

            int multByte = a * b;
            Console.WriteLine("Multiplication = " + multByte);
            
            float divByte1 = (float)a / b;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divByte1));
            Console.WriteLine("Division = " + divByte1);

            double divByte2 = (double)a / b;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divByte2));
            Console.WriteLine("Division = " + divByte2);

            byte aa = 150;
            byte bb = 200;
                        
            byte sumByte3 = (byte)(aa + bb);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumByte3));
            Console.WriteLine("Sum = " + sumByte3);
            Console.WriteLine();





            Console.WriteLine("Short operations:");

            short c = 10;
            short d = 8;

            //short sumShort = (short)(c + d);
            short sumShort1 = Convert.ToInt16(c + d);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumShort1));
            Console.WriteLine("Sum = " + sumShort1);

            int sumShort2 = c + d;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumShort2));
            Console.WriteLine("Sum = " + sumShort2);

            short subShort = Convert.ToInt16(c - d);
            Console.WriteLine("Type is " + Convert.GetTypeCode(subShort));
            Console.WriteLine("Subtraction = " + subShort);

            short multShort = Convert.ToInt16(c * d);
            Console.WriteLine("Type is " + Convert.GetTypeCode(multShort));
            Console.WriteLine("Multiplication = " + multShort);

            float divShort = (float)c / d;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divShort));
            Console.WriteLine("Division = " + divShort);

            short cc = 15000;
            short dd = 20000;

            ushort sumShort3 = Convert.ToUInt16(cc + dd);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumShort3));
            Console.WriteLine("Sum = " + sumShort3);
            Console.WriteLine();





            Console.WriteLine("Int operations:");

            int e = 20;
            int f = 30;

            int sumInt = e + f;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumInt));
            Console.WriteLine("Sum = " + sumInt);

            int subInt = e - f;
            Console.WriteLine("Type is " + Convert.GetTypeCode(subInt));
            Console.WriteLine("Subtraction = " + subInt);
            Console.WriteLine("Absolute value of subtraction = " + Math.Abs(subInt));

            int multInt = e * f;
            Console.WriteLine("Type is " + Convert.GetTypeCode(multInt));
            Console.WriteLine("Multiplication = " + multInt);

            float divInt = (float)e / f;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divInt));
            Console.WriteLine("Division = " + divInt);

            int ee = 2000000000;
            int ff = 1000000000;

            uint sumInt1 = (uint)(int)(ee + ff);
            //uint sumInt1 = (uint)ee + (uint)ff;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumInt1));
            Console.WriteLine("Sum = " + sumInt1);
            Console.WriteLine();





            Console.WriteLine("Long operations:");

            long g = 150;
            long h = 100;

            //long sumLong = (long)(g + h);
            long sumLong = Convert.ToInt64(g + h);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumLong));
            Console.WriteLine("Sum = " + sumLong);

            long subLong = Convert.ToInt64(g - h);
            Console.WriteLine("Type is " + Convert.GetTypeCode(subLong));
            Console.WriteLine("Subtraction = " + subLong);
                        
            long multLong = Convert.ToInt64(g * h);
            Console.WriteLine("Type is " + Convert.GetTypeCode(multLong));
            Console.WriteLine("Multiplication = " + multLong);

            float divLong = (float)g / h;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divLong));
            Console.WriteLine("Division = " + divLong);
            Console.WriteLine();





            Console.WriteLine("Float operations:");

            float k = 2.5f;
            float l = 4.25f;

            float sumFloat = k + l;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumFloat));
            Console.WriteLine("Sum = " + sumFloat);

            float subFloat = k - l;
            Console.WriteLine("Type is " + Convert.GetTypeCode(subFloat));
            Console.WriteLine("Subtraction = " + subFloat);

            float multFloat = k * l;
            Console.WriteLine("Type is " + Convert.GetTypeCode(multFloat));
            Console.WriteLine("Multiplication = " + multFloat);

            float divFloat = k / l;            
            Console.WriteLine("Type is " + Convert.GetTypeCode(divFloat));
            Console.WriteLine("Division = " + divFloat);
            Console.WriteLine();





            Console.WriteLine("Double operations:");

            double m = 6.15;
            double n = 4.85;

            double sumDouble = m + n;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumDouble));
            Console.WriteLine("Sum = " + sumDouble);

            double subDouble = m - n;
            Console.WriteLine("Type is " + Convert.GetTypeCode(subDouble));
            Console.WriteLine("Subtraction = " + subDouble);

            double multDouble = m * n;
            Console.WriteLine("Type is " + Convert.GetTypeCode(multDouble));
            Console.WriteLine("Multiplication = " + multDouble);

            double divDouble = m / n;
            Console.WriteLine("Type is " + Convert.GetTypeCode(divDouble));
            Console.WriteLine("Division = " + divDouble);
            Console.WriteLine();





            Console.WriteLine("Decimal operations:");

            decimal p = 8.135m;
            decimal q = 2.4595m;

            decimal sumDecimal = p + q;
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumDecimal));
            Console.WriteLine("Sum = " + sumDecimal);

            decimal subDecimal = p - q;
            Console.WriteLine("Type is " + Convert.GetTypeCode(subDecimal));
            Console.WriteLine("Subtraction = " + subDecimal);

            decimal multDecimal = p * q;            
            Console.WriteLine("Type is " + Convert.GetTypeCode(multDecimal));
            Console.WriteLine("Multiplication = " + multDecimal);

            decimal divDecimal = p / q;            
            Console.WriteLine("Type is " + Convert.GetTypeCode(divDecimal));
            Console.WriteLine("Division = " + divDecimal);
            Console.WriteLine();





            Console.WriteLine("Char operations:");
            
            char x = '#';
            char y = 'B';

            char sumChar = Convert.ToChar(x + y);
            Console.WriteLine("Type is " + Convert.GetTypeCode(sumChar));
            Console.WriteLine("Sum = " + sumChar);

            char subChar = Convert.ToChar(y - x);
            Console.WriteLine("Type is " + Convert.GetTypeCode(subChar));
            Console.WriteLine("Subtraction = " + subChar);

            char xx = (char)7;
            char yy = (char)13;
            
            char multChar = Convert.ToChar(xx * yy);
            Console.WriteLine("Type is " + Convert.GetTypeCode(multChar));
            Console.WriteLine("Multiplication = " + multChar);

            char xxx = 'd';
            char yyy = (char)24;

            char divChar = Convert.ToChar(xxx / yyy);
            Console.WriteLine("Type is " + Convert.GetTypeCode(divChar));
            Console.WriteLine("Division = " + divChar);
            Console.WriteLine();





            Console.WriteLine("Bool operations:");

            //bool s = false;
            bool s;
            bool t = true;

            // bool-երի հետ թվաբանական գործողություններ չենք կարող անել
            Console.WriteLine("We can't do arithmetic operations with bools!");

            Console.ReadKey();
        }
    }
}