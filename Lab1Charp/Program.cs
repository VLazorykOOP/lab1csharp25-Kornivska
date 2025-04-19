using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть завдання (1–6):");
        Console.Write("1. Гіпотенуза\n2. Рівняння\n3. Точка в області\n4. Назва місяця\n5. Різниця чисел\n6. Вираз\nВаш вибір: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Task1_Hypotenuse();
                break;
            case 2:
                Task2_QuadraticRoots();
                break;
            case 3:
                Task3_PointInArea();
                break;
            case 4:
                Task4_DayToMonth();
                break;
            case 5:
                Task5_Subtract();
                break;
            case 6:
                Task6_Expression();
                break;
            default:
                Console.WriteLine("Невірний вибір.");
                break;
        }
    }

    static void Task1_Hypotenuse()
    {
        Console.Write("Введіть катет a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть катет b: ");
        double b = double.Parse(Console.ReadLine());
        double c = Math.Sqrt(a * a + b * b);
        Console.WriteLine($"Гіпотенуза: {c}");
    }

    static void Task2_QuadraticRoots()
    {
        Console.Write("Введіть a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введіть c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
            Console.WriteLine("Розв'язків немає.");
        else
            Console.WriteLine("Розв'язки існують.");
    }

    static void Task3_PointInArea()
    {
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());

        double r1 = 15, r2 = 25;
        double d = x * x + y * y;

        if (Math.Abs(d - r1 * r1) < 0.0001 || Math.Abs(d - r2 * r2) < 0.0001)
            Console.WriteLine("На межі");
        else if (d > r1 * r1 && d < r2 * r2)
            Console.WriteLine("Так");
        else
            Console.WriteLine("Ні");
    }

    static void Task4_DayToMonth()
    {
        Console.Write("Введіть n (днів після 1.01.1990): ");
        int n = int.Parse(Console.ReadLine());

        DateTime start = new DateTime(1990, 1, 1);
        DateTime result = start.AddDays(n);
        Console.WriteLine($"Місяць: {result.ToString("MMMM")}");
    }

    static void Task5_Subtract()
    {
        Console.Write("Введіть перше число: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введіть друге число: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine($"Різниця: {a - b}");
    }

    static void Task6_Expression()
{
    Console.Write("Введіть x: ");
    double x = double.Parse(Console.ReadLine());
    Console.Write("Введіть y: ");
    double y = double.Parse(Console.ReadLine());

    double numerator = x + Math.Pow(y, 2) + 3;
    double denominator = Math.Pow(x, 2) + 5;
    double result = x * y + numerator / denominator;

    Console.WriteLine($"Результат: {result}");
}
}
