using EmoInheritanceClass;
using System;

namespace Childs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new();
            Child c = new();

            Console.WriteLine("Массив у класса Parent до сортировки:");
            ShowMassive(p.Nums);

            p.BubbleSort();

            Console.WriteLine("Массив после сортировки.");
            ShowMassive(p.Nums);

            Console.WriteLine($"Максимальный элемент: {p.Max()}");

            Console.WriteLine("\n");

            Console.WriteLine("Массив у класса Child до сортировки:");
            ShowMassive(c.Nums);

            c.BubbleSort();

            Console.WriteLine("Массив после сортирвоки:");
            ShowMassive(c.Nums);

            c.Zamena();

            Console.WriteLine("Массив класса Child после вызовы метода замены:");
            ShowMassive(c.Nums);
        }

        static void ShowMassive(int[] massive)
        {
            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write($"[{i}] = {massive[i]}; ");
            }

            Console.WriteLine();
        }
    }
}
