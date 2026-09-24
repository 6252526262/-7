
//***************************************************************************
//*практическая работа №7 варииант 8                                        *
//*Выполнил Тарасов Александр группа 2ИСПд                                  *
//*задание составить программу для подсчета общей цены за день в спорт зале * 
//                                                                          *
//***************************************************************************
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "практическая7";
        Console.Write("Здравствуйте");
        Console.Write("\nВведите стоимость 1 часа тренировки: ");
        double price = double.Parse(Console.ReadLine());

        // Проверка корректности цены
        if (price <= 0)
        {
            Console.WriteLine("Ошибка: цена должна быть больше 0");
            Console.ReadKey();
            return; // Завершаем программу
        }

        Console.Write("Введите количество посетителей: ");
        int count = int.Parse(Console.ReadLine());

        // Проверка корректности количества посетителей
        if (count <= 0)
        {
            Console.WriteLine("Ошибка: количество посетителей должно быть больше 0");
            Console.ReadKey();
            return; // Завершаем программу
        }

        double totalSum = 0;

        
        for (int i = 1; i <= count; i++)
        {
            Console.Write("Введите количество часов для посетителя " + i + ": ");
            double hours = double.Parse(Console.ReadLine());

            if (hours <= 0)
            {
                Console.WriteLine("Ошибка: количество часов должно быть больше 0");
                Console.ReadKey();
                return;
            }

            totalSum = totalSum + (hours * price);
        }

        Console.WriteLine("\nОбщая сумма за день: " + totalSum + " руб.");

        Console.ReadKey();
    }
}
