namespace MindBoxTask.Shape;

public interface ITriangle
{
    double Aside { get; set; }
    double Bside { get; set; }
    double Cside { get; set; }

    public double CalcSquare();
    public bool IsRectangular();
}