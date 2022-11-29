using System;
//було порушено принцип підстановки Лісков (LSP)

public interface Area
{
    public int GetArea();
}
public class Rectangle : Area
{
    public int Width { get; set; }
    public int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : Area
{
    public int Width { get; set; }
    public int GetArea()
    {
        return Width * Width;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 10;

        Console.WriteLine(rect.GetArea());

        Console.ReadKey();
    }
}
