using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
           // Rectangle r = new Rectangle(3, 5);
            Triangle t = new Triangle(3, 5);
            Circle c = new Circle(3);
            Square s = new Square(4);
           // r.FindArea();
            t.FindArea();
            c.FindArea();
            s.FindArea();
    
        }
    }
}
