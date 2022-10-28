using MindBoxTask.Shape;

namespace MindBoxTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Circle",12);
            Triangle triangle = new Triangle("Triangle",5,5,5);

            Console.WriteLine(circle.CalcSquare());
            
            Console.WriteLine(triangle.CalcSquare());
            Console.WriteLine(triangle.IsRectangular());
        }
    }
}