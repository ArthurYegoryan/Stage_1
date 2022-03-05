using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*namespace Lessons_Homeworks.Lesson_8_Classes_Structs
{
    *//*Create a "struct" to store data of 2D points. The fields for each point will be:
      x coordinate(short)
      y coordinate(short)
      r(red colour, byte)
      g(green colour, byte)
      b(blue colour, byte)*//*
    enum Colour : byte
    {
        Red,
        Green,
        Blue,
    }
    
    struct Point
    {
        public short x;
        public short y;
        public Colour colour;        
    }

    internal class Struct_Exercises
    {
        static void Main()
        {
            Point point1 = new Point();
            Point point2 = new Point();
            Point point3 = new Point();

            point1.x = 4;
            point1.y = 5;
            point1.colour = Colour.Red;
            Console.WriteLine($"X = {point1.x} | Y = {point1.y} | Colour = {point1.colour}");

            point2.x = 8;
            point2.y = 9;
            point2.colour = Colour.Green;
            Console.WriteLine($"X = {point2.x} | Y = {point2.y} | Colour = {point2.colour}");

            point3.x = 1;
            point3.y = 2;
            point3.colour = Colour.Blue;
            Console.WriteLine($"X = {point3.x} | Y = {point3.y} | Colour = {point3.colour}");
        }
    }
}*/
