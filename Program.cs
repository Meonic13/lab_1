using System;

namespace lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 18: Площадь круга и кольца");
            Console.WriteLine("1. Площадь большого круга (R)");
            Console.WriteLine("2. Площадь малого круга (r)");
            Console.WriteLine("3. Площадь кольца и процент от большого круга");

            double R = 0, r = 0;
            bool R_set = false, r_set = false;

            while (true)
            {
                Console.WriteLine("\nВыберите задачу (1, 2, 3) или 0 для выхода:");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Программа завершена.");
                    break;
                }

                try
                {
                    if (choice == "1")
                    {
                        Console.WriteLine("Задача 1: S = pi*R^2");
                        Console.Write("Введите R (0.01–1000): ");
                        R = double.Parse(Console.ReadLine());
                        if (R <= 0 || R > 1000)
                        {
                            Console.WriteLine("Ошибка: R должно быть в диапазоне 0.01–1000");
                            continue;
                        }
                        double areaBig = Math.PI * R * R;
                        Console.WriteLine($"Результат: S = {areaBig:F2}");
                        R_set = true;
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("Задача 2: S = pi*r^2");
                        Console.Write("Введите r (0.01–1000): ");
                        r = double.Parse(Console.ReadLine());
                        if (r <= 0 || r > 1000)
                        {
                            Console.WriteLine("Ошибка: r должно быть в диапазоне 0.01–1000");
                            continue;
                        }
                        double areaSmall = Math.PI * r * r;
                        Console.WriteLine($"Результат: S = {areaSmall:F2}");
                        r_set = true;
                    }
                    else if (choice == "3")
                    {
                        if (!R_set || !r_set)
                        {
                            Console.WriteLine("Сначала выполните задачи 1 и 2 для ввода R и r");
                            continue;
                        }
                        if (r >= R)
                        {
                            Console.WriteLine("Ошибка: r должно быть меньше R");
                            continue;
                        }
                        Console.WriteLine("Задача 3: Sкольца = pi(R^2 - r^2)");
                        double areaBig = Math.PI * R * R;
                        double areaSmall = Math.PI * r * r;
                        double areaRing = Math.PI * (R * R - r * r);
                        double procent = (areaRing / areaBig) * 100;

                        Console.WriteLine($"Площадь большого круга: {areaBig:F2}");
                        Console.WriteLine($"Площадь малого круга: {areaSmall:F2}");
                        Console.WriteLine($"Площадь кольца: {areaRing:F2}");
                        Console.WriteLine($"Доля кольца: {procent:F2}%");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Введите 1, 2, 3 или 0");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка! Введите число (дробная часть через запятую)");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}