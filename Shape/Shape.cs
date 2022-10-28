namespace MindBoxTask.Shape;

public abstract class Shape
{
    private string FigureName { get; set; }

    protected Shape(string figureName)
    {
        FigureName = figureName;
    }
}