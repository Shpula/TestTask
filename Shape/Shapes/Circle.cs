namespace MindBoxTask.Shape;

public class Circle : Shape, ICircle
{
    public double Radius { get; set; }

    public Circle(string figureName, double radius) : base(figureName)
    {
        Radius = radius;
    }
    
    public double CalcSquare()
    {
        double result = Math.Round(
            Math.PI * Math.Pow(Radius, 2)
            , 1);
        return result;
    }
}