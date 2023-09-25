namespace Demo78___PatternMatching.Models;

public class Shape
{
    
}

public class Rectagle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public void Deconstruct(out int width, out int height)
    {
        width = this.Width;
        height = this.Height;
    }
}

public class Circle : Shape
{
    public int Radius { get; set; }
}