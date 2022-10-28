namespace MindBoxTask.Shape;

public class Triangle : Shape, ITriangle
{
    public double Aside { get; set; }
    public double Bside { get; set; }
    public double Cside { get; set; }

    public Triangle(string figureName, double aside, double bside, double cside) : base(figureName)
    {
        Aside = aside;
        Bside = bside;
        Cside = cside; 
    }

    public double CalcSquare() 
    {
        double perimeter = (Aside + Bside + Cside) / 2;
        double result = Math.Round(
            Math.Sqrt(perimeter * (perimeter  - Aside) * (perimeter  - Bside) * (perimeter  - Cside))
            , 1);
        return result;
    }
    
    public bool IsRectangular()
    {
        bool flag = (Aside == Math.Sqrt(Math.Pow(Bside, 2) + Math.Pow(Cside, 2))
                      || Aside == Math.Sqrt(Math.Pow(Bside, 2) + Math.Pow(Cside, 2))
                      || Aside == Math.Sqrt(Math.Pow(Bside, 2) + Math.Pow(Cside, 2)));
        return flag;
    }
}