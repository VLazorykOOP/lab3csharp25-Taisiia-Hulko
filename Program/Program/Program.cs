using System;

enum ColorName
{
    Red,
    Green,
    Blue,
    Yellow,
    Purple
}

class DRomb
{
    protected int d1;
    protected int d2;
    protected ColorName c; // тепер тип — ColorName

    public DRomb(int d1, int d2, ColorName color)
    {
        this.d1 = d1;
        this.d2 = d2;
        this.c = color;
    }

    // Властивості
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

    public ColorName Color
    {
        get { return c; }
    }

    // Метод для виводу довжин
    public void PrintLengths()
    {
        Console.WriteLine($"Діагональ 1: {d1}, Діагональ 2: {d2}, Колір: {c}");
    }

    // Метод для обчислення площі
    public double Area()
    {
        return (d1 * d2) / 2.0;
    }

    // Метод для обчислення периметра
    public double Perimeter()
    {
        double side = Math.Sqrt((d1 * d1 + d2 * d2) / 4.0);
        return 4 * side;
    }

    // Метод для перевірки, чи це квадрат
    public bool IsSquare()
    {
        return d1 == d2;
    }
}

class Program
{
    static void Main()
    {
        DRomb[] rombs = new DRomb[]
        {
            new DRomb(10, 10, ColorName.Red),
            new DRomb(12, 16, ColorName.Green),
            new DRomb(8, 8, ColorName.Blue),
            new DRomb(14, 20, ColorName.Yellow),
            new DRomb(15, 15, ColorName.Purple)
        };

        int squareCount = 0;

        foreach (DRomb r in rombs)
        {
            r.PrintLengths();
            Console.WriteLine($"Площа: {r.Area()}");
            Console.WriteLine($"Периметр: {r.Perimeter()}");
            if (r.IsSquare())
            {
                Console.WriteLine("Це квадрат!");
                squareCount++;
            }
            Console.WriteLine("----------------------------");
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
