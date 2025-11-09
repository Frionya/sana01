using System;

class LinearExpressions1
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть c: ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("Введіть d: ");
        double d = double.Parse(Console.ReadLine());
        double x = (a + 2 * b - c + d) / (c * d)
                   + (a + b) / (c - d)
                   + Math.Pow(a, 2) / Math.Pow(b, 2);

        double y = (5 * (a + b) * (c - d)) / (0.5 * c)
                   + Math.Pow(d, 2) * (Math.Pow(a, 2) - Math.Pow(b, 2)) / (b - a);

        double z = ((Math.Pow(x, 2) - 2 * x) * (Math.Pow(x, 3) - 4 * (Math.Pow(x, 4) + 1)) * (1 - b))
                   / (5 * a + 3 * b);

        double r = (0.5 * a + (3.0 / 4.0) * b - 7.0 / 5.0)
                   / (3 * c + 1)
                   + 1.0 / (a - c);
        Console.WriteLine($"\nРезультати обчислень (LinearExpressions1):");
        Console.WriteLine($"x = {x}");
        Console.WriteLine($"y = {y}");
        Console.WriteLine($"z = {z}");
        Console.WriteLine($"r = {r}");
    }
}
