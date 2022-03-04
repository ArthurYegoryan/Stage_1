using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Lessons_Homeworks
{
    enum Color
    {
        Red,
        Green,
        Blue,
        Orange,
        Yellow
    }

    class Point                         // Կլասսը օբյեկտ սարքելու շաբլոն է
    {
        public int x;
        public int y;
        public Color color;
    }

    class Student
    {
        public Guid ID;                  // Globally Unique Identifier (128 bit-անոց ամբողջ թիվ է, օգտագործվում է ID-ները տարբերակելու համար)
        public string firstName;
        public string lastName;
        public string middleName;
        public int age;
        public string group;
    }

    internal class _8_Lesson_Classes
    {
        static Student GetStudent()
        {
            Student student = new Student();        // Սարքում ենք instance-ը

            student.ID = Guid.NewGuid();            // Ստեղծում ենք ID 
            student.firstName = "Arthur";
            student.lastName = "Yegoryan";
            student.middleName = "Zavens";
            student.age = 24;
            student.group = "Basic IT Center";

            return student;
        }

        static void Print(Student student)
        {
            Console.WriteLine("Student information:");
            Console.WriteLine($"Student ID: {student.ID}");
            Console.WriteLine($"Student firstname: {student.firstName}");
            Console.WriteLine($"Student lastname: {student.lastName}");
            Console.WriteLine($"Student middlebame: {student.middleName}");
            Console.WriteLine($"Student age: {student.age}");
            Console.WriteLine($"Student group: {student.group}");
        }
        static void Main()
        {
            Student firstStudent = GetStudent();

            Print(firstStudent);

            Point point1 = new Point();           // Եթե new-ն չլինի, ապա point1-ը կնայի stack-ին և ոչինչ չգտնելով կստանա null

            point1.x = 4;
            point1.y = 2;
            point1.color = Color.Red;

            Console.WriteLine($"X: {point1.x}, Y: {point1.y}, Color: {point1.color}");

            Point point2 = new Point();

            //point2 = null;                       // Եթե point2-ին տանք null, ապա հետագայում նրա մեջի արժեքների վերագրումը սխալ կտա

            point2.x = 2;
            point2.y = 6;
            point2.color = Color.Green;

            Console.WriteLine($"X: {point2.x}, Y: {point2.y}, Color: {point2.color}");
        }
    }
}*/
