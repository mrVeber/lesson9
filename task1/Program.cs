using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Добрый день, вас приветствует программа калькулирования ваших чисел!");
                Console.Write("Введите первое число: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nКак будем калькулировать ваши числа: \n1.Складывать (нажмите 1) \n2.Вычитать (нажмите 2) \n3.Умножать (нажмите 3)\n4.Делить (нажмите 4) \nВаш выбор: ");
                int imput = Convert.ToInt32(Console.ReadLine());
                switch (imput)
                    {
                    case 1:
                        Console.WriteLine($"Вы выбрали сложение \nРезультат равен: {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"Вы выбрали вычитание \nРезультат равен: {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"Вы выбрали умножение \nРезультат равен: {a * b}");
                        break;
                    case 4:
                        Console.WriteLine($"Вы выбрали деление \nРезультат равен: {a / b}");
                        break;
                    default:
                        Console.WriteLine("Под такой цифрой операции нет! Будьте внимательны.");
                        break;
                }     
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();

        }
    }
}
