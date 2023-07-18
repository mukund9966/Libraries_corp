using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shapes;
namespace FinalAreaFInal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y, res;
            int c;
            Console.WriteLine("Which area you want to find : \n 1) Square \n 2) Rectangle \n 3) Circle \n 4) Triangle");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1:
                    {

                        Square square = new Square();

                        Console.WriteLine("Enter side of square");
                        x = double.Parse(Console.ReadLine());
                        res = square.Area(x);
                        Console.WriteLine("Area is " + res);
                        break;
                    }
                case 2:
                    {
                        Rectangle rec = new Rectangle();
                        Console.WriteLine("Enter length of rectangle");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enetr the rbeadth of rectangle");
                        y = double.Parse(Console.ReadLine());
                        res = rec.Area(x, y);
                        Console.WriteLine("Area is " + res);
                        break;
                    }
                case 3:
                    {
                        Circle circle = new Circle();
                        Console.WriteLine("Enter radius of circle");
                        x = double.Parse(Console.ReadLine());
                        res = circle.Area(x);
                        Console.WriteLine("Area is " + res);
                        break;
                    }
                case 4:
                    {
                        Triangle triangle = new Triangle();
                        Console.WriteLine("Enter length of perpendicular");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enetr the length of base");
                        y = double.Parse(Console.ReadLine());
                        res = triangle.Area(x, y);
                        Console.WriteLine("Area is " + res);
                        break;
                    }
            }
            Console.ReadKey();
        }
    }
}
