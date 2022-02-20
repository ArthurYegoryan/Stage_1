namespace Lessons_Homeworks.Lesson_3
{
    internal class Lesson_3_2
    {
        static void Main()
        {
            int a = 10;
            int b = -20;
            int c = 1;


            int n1 = Math.Abs(b);    // Վերադարձնում է ցանկացած թվի դարական արժեքը
            Console.WriteLine(n1);

            double n2 = Math.Acos(c);    // Վերադարձնում է այն անկյունը, որի կոսինուսը նշված թիվն է
            Console.WriteLine(n2);

            double n3 = Math.Acosh(c);   // Վերադարձնում է այն անկյունը, որի հիպերբոլիկական կոսինուսը նշված թիվն է
            Console.WriteLine(n3);

            double n4 = Math.Asin(c);    // Վերադարձնում է այն անկյունը, որի սինուսը նշված թիվն է
            Console.WriteLine(n4);

            double n5 = Math.Asinh(c);   // Վերադարձնում է այն անկյունը, որի հիպերբոլիկական սինուսը նշված թիվն է
            Console.WriteLine(n5);

            double n6 = Math.Atan(c);    // Վերադարձնում է այն անկյունը, որի տանգենսը նշված թիվն է
            Console.WriteLine(n6);

            double n7 = Math.Atan2(n5, n6);   // Վերադարձնում է այն անկյունը, որի տանգենսը նշված 2 թվերի քանորդն է
            Console.WriteLine(n7);

            double n8 = Math.Atanh(c);   // Վերադարձնում է այն անկյունը, որի հիպերբոլիկական տանգենսը նշված թիվն է
            Console.WriteLine(n8);

            long n9 = Math.BigMul(a, b);   // Վերադարձնում է 2 թվերի ամբողջ արտադրյալը
            Console.WriteLine(n9);

            double n10 = Math.BitDecrement(a);  // Վերադարձնում է double թվի ամենավերջին թվանշանից հանած 1
            Console.WriteLine(n10);

            double n11 = Math.BitIncrement(a);  // Վերադրձնում է double թվի ամենավերջին թվանշանին գումարած 1
            Console.WriteLine(n11);

            double n12 = Math.Cbrt(a);    // Վերադարձնում է տվյալ թվի խորանարդ արմատը
            Console.WriteLine(n12);

            decimal a1 = 6.99m;
            decimal n13 = Math.Ceiling(a1);   // Վերադարձնում է ամենափոքր թիվը, որը մեծ է կամ հավասար տրված թվից
            Console.WriteLine(n13);

            byte b1 = 2;
            byte b2 = 4;
            byte b3 = 6;
            byte n14 = Math.Clamp(b3, b1, b2);   //    Վերադարձնում է այն թիվը, որը b3-ը սեղմելով տեղավորվում է b1-ից 
            Console.WriteLine(n14);              // b2 միջակայքում

            double c1 = 10.5d;
            double c2 = -7.25d;
            double n15 = Math.CopySign(c1, c2);   // Վերադարձնում է թիվ 1-ին արգումենտի մեծությամբ և 2-րդ արգումենտի նշանով
            Console.WriteLine(n15);

            double n16 = Math.Cos(a);     // Վերադարձնում է տրված անկյան կոսինուսը
            Console.WriteLine(n16);

            double n17 = Math.Cosh(a);    // Վերադարձնում է տրված անկյան հիպերբոլային կոսինուսը
            Console.WriteLine(n17);

            int c3;
            int n18 = Math.DivRem(b, a, out c3);   // Բաժանում է 2 արգումենտները և ամբողջ արդյունքը վերադարձնում է
            Console.WriteLine(n18);

            const double e = Math.E;        // Վերադարձնում է կոնստանտ e-ի արժեքը
            Console.WriteLine(e);

            bool n19 = Math.Equals(a, b);    // Համեմատում է արգումենտները հավասար են թե ոչ
            Console.WriteLine(n19);

            double n20 = Math.Exp(c);       // Վերադարձնում է կոնստանտ e-ի տրված աստիճանը
            Console.WriteLine(n20);

            decimal n21 = Math.Floor(a1);      // Վերադարձնում է ամենամեժ դեցիմալ արժեքը, որը <= է տրված թվից
            Console.WriteLine(n21);

            double aa1 = 2.5d;
            double aa2 = 3.25d;
            double aa3 = 4.75d;
            double n22 = Math.FusedMultiplyAdd(aa1, aa2, aa3);   // Վերադարձնում է aa1 * aa2 + aa3 արտահայտության արժեքը
            Console.WriteLine(n22);

            double n23 = Math.IEEERemainder(5.5d, 2.5d);    // Վերադարձնում է արգումենտների բաժանումից ստացվող մնացորդը
            Console.WriteLine(n23);

            int n24 = Math.ILogB(a);       // Վերադարձնում է Log(a) B հիմքով
            Console.WriteLine(n24);

            double n25 = Math.Log(a);      // Վերադարձնում է Log(a) կոնստանտ e հիմքով
            Console.WriteLine(n25);

            double n26 = Math.Log10(a);    // Վերադարձնում է Log(a) 10 հիմքով
            Console.WriteLine(n26);

            double n27 = Math.Log2(a);     // Վերադարձնում է Log(a) 2 հիմքով
            Console.WriteLine(n27);

            byte bb1 = 15;
            byte bb2 = 20;
            byte n28 = Math.Max(bb1, bb2);   // Վերադարձնում է 2 թվերից մեծը
            Console.WriteLine(n28);

            double n29 = Math.MaxMagnitude(aa1, aa2);    // Վերադարձնում է 2 double թվերից մեծը
            Console.WriteLine(n29);

            byte n30 = Math.Min(bb1, bb2);    // Վերադարձնում է տրված արգումենտներից փոքրը
            Console.WriteLine(n30);

            double n31 = Math.MinMagnitude(aa1, aa2);    // Վերադարձնում է 2 double թվերից փոքրը
            Console.WriteLine(n31);

            const double n32 = Math.PI;      // Վերադարձնում է կոնստանտ п-ի արժեքը
            Console.WriteLine(n32);

            double n33 = Math.Pow(aa1, aa2);    // Վերադարձնում է aa1-ի aa2 աստիճանը
            Console.WriteLine(n33);

            double n34 = Math.ReciprocalEstimate(aa1);   // Վերադարձնում է տրված թվի հակադարձ թիվը
            Console.WriteLine(n34);

            double n35 = Math.ReciprocalSqrtEstimate(aa1);    // Վերադարձնում է տրված թվի հակադարձ թվի քառակուսի արմատը
            Console.WriteLine(n35);

            bool n36 = Math.ReferenceEquals(aa1, aa2);    // Համեմատում է այս թվերը հավասար են թե ոչ
            Console.WriteLine(n36);

            decimal n37 = Math.Round(a1);     // Կլորացնում է դեցիմալ թիվը, 0,5-ից բարձրը կլորանում է վերև   
            Console.WriteLine(n37);

            int aaa = 2;
            double n38 = Math.ScaleB(aa1, aaa);    // Վերադարձնում է aa1*2^aaa արտահայտության արժեքը
            Console.WriteLine(n38);

            int n39 = Math.Sign(a1);      // Վերադարձնում է թվի նշանը 1 կամ -1
            Console.WriteLine(n39);

            double n40 = Math.Sin(90d);    // Վերադարձնում է տրված անկյան սինուսը
            Console.WriteLine(n40);

            Console.WriteLine(Math.SinCos(90d));    // Վերադարձնում է տրված անկյան սինուսը և կոսինուսը

            double n41 = Math.Sinh(aa1);     // Վերադարձնում է տրված անկյան հիպերբոլային սինուսը
            Console.WriteLine(n41);

            double n42 = Math.Sqrt(aa1);     // Վերադարձնում է տրված թվի արմատը
            Console.WriteLine(n42);

            double n43 = Math.Tan(aa1);     // Վերադարձնում է տրված անկյան տանգենսը
            Console.WriteLine(n43);

            double n44 = Math.Tanh(aa1);     // Վերադարձնում է տրված անկյան հիպերբոլային տանգենսը
            Console.WriteLine(n44);

            const double Rad = Math.Tau;     // Վերադարձնում է կոնստանտ ռադիանսի արժեքը
            Console.WriteLine(Rad);

            decimal n45 = Math.Truncate(a1);   // Վերադարձնում է տրված դեցիմալ թվի ամբողջ մասը
            Console.WriteLine(n45);
        }
    }
}
