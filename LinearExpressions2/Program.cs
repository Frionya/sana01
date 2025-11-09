using System;

class LinearExpressions2
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Введення даних
        Console.Write("Введіть m: ");
        double m = double.Parse(Console.ReadLine());
        Console.Write("Введіть n: ");
        double n = double.Parse(Console.ReadLine());
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());

        // Обчислення z1, z2, y
        double z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) /
                    (Math.Sqrt(Math.Pow(m, 3) * n) + n * m + Math.Pow(m, 2) - m);

        double z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;

        double y = 2.4 * ((Math.Pow(x, 2) + b) / a)
                   + (a - b) * Math.Pow(Math.Sin(a - b), 2)
                   + Math.Pow(10, -2) * (x - b);

        // Виведення результатів
        Console.WriteLine($"\nРезультати обчислень (LinearExpressions2):");
        Console.WriteLine($"z1 = {z1}");
        Console.WriteLine($"z2 = {z2}");
        Console.WriteLine($"y = {y}");
    }
}
