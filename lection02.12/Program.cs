using System;


class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }


    public Rectangle()
    {
        Width = 12;
        Height = 14;
        Console.WriteLine("Конструктор по умолчанию вызван");
    }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
        Console.WriteLine("Конструктор с параметрами вызван");
    }

    public Rectangle(Rectangle other)
    {
        Width = other.Width;
        Height = other.Height;
        Console.WriteLine("Конструктор копирования вызван");
    }

    public double GetArea()
    {
        return (Width * Height);
    }

    ~Rectangle() 
    {
        Console.WriteLine("Деструктор вызван");
    }

}

class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        Rectangle rect2 = new Rectangle(10,15);
        Rectangle rect3 = new Rectangle(rect2);

        Console.WriteLine($"Площадь rect1 {rect.GetArea()}");
        Console.WriteLine($"Площадь rect2 {rect2.GetArea()}");
        Console.WriteLine($"Площадь rect3 {rect3.GetArea()}");

        Console.ReadLine();


    }

}