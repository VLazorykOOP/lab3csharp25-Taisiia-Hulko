using System;

class DRomb
{
    protected int d1, d2;
    protected int color;

    public DRomb(int d1, int d2, int color)
    {
        this.d1 = d1;
        this.d2 = d2;
        this.color = color;
    }

    public int D1
    {
        get { return d1; }
        set { d1 = value; }
    }

    public int D2
    {
        get { return d2; }
        set { d2 = value; }
    }

    public int Color
    {
        get { return color; }
    }

    public void DisplayDimensions()
    {
        Console.WriteLine($"Діагоналі ромба: D1 = {d1}, D2 = {d2}");
    }

    public double CalculatePerimeter()
    {
        double sideLength = Math.Sqrt(Math.Pow(d1 / 2.0, 2) + Math.Pow(d2 / 2.0, 2));
        return 4 * sideLength;
    }

    public double CalculateArea()
    {
        return (d1 * d2) / 2.0;
    }

    public bool IsSquare()
    {
        return d1 == d2;
    }

    public void DisplayColor()
    {
        Console.WriteLine($"Колір ромба: {GetColorName()}");
    }

    private string GetColorName()
    {
        return color switch
        {
            1 => "Червоний",
            2 => "Синій",
            3 => "Зелений",
            4 => "Жовтий",
            _ => "Невідомий"
        };
    }
}

class Program
{
    static void Main(string[] args)
    {
        DRomb[] rombs = {
            new DRomb(10, 15, 1),
            new DRomb(5, 5, 2),
            new DRomb(8, 12, 3)
        };

        int squareCount = 0;

        foreach (var romb in rombs)
        {
            romb.DisplayDimensions();
            romb.DisplayColor();
            Console.WriteLine($"Периметр ромба: {romb.CalculatePerimeter():F2}");
            Console.WriteLine($"Площа ромба: {romb.CalculateArea():F2}");

            if (romb.IsSquare())
            {
                squareCount++;
                Console.WriteLine("Це квадрат.");
            }
            else
            {
                Console.WriteLine("Це не квадрат.");
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Кількість квадратів у масиві: {squareCount}");
    }
}
