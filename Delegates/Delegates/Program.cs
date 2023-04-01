using System;

namespace MyJope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 задание
            CharDelegate ob = new CharDelegate();
            CharAction charAction = ob.SetSymb;

            Console.WriteLine($"Переменная класса до вызова делегата: {ob.Symb}");
            charAction.Invoke('S');
            Console.WriteLine($"После вызова делегата с аргументом \"S\": {ob.Symb}\n");

            //2 задание
            TextDelegate textDelegate = TextMethods.CountSymbInText;

            char symb = 'а';
            string text = "20 22 66 Москва. Поднял баблаа!";

            Console.WriteLine($"Буква:\"{symb}\"; Строка: {text}");

            Console.WriteLine($"Результат выполнения метода CountSymbInText: {textDelegate.Invoke(symb, text)}");

            textDelegate -= TextMethods.CountSymbInText;
            textDelegate += TextMethods.FirstIndexOfSymbInText;
            Console.WriteLine($"Результат выполнения метода FirstIndexOfSymbInText: {textDelegate.Invoke(symb, text)}");

            Console.WriteLine();

            //3 задание
            MathDelegate mathDelegate = delegate(double a, double b, double c)
            {
                //Решается квадротное уравнение и возвращается сумма корней
                double D = Math.Pow(b, 2) - 4 * a * c;
                double x1 = 0, x2 = 0;

                if (D < 0)
                {
                    Console.WriteLine("Квадротное уравнение не имеет корней");
                } else if (D == 0)
                {
                    x1 = -b / (2 * a);
                } else
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }

                return x1 + x2;
            };

            Console.WriteLine($"Сумма корней -4 28 -49 = {mathDelegate.Invoke(-4, 28, -49)}\n");

            //4 задание
            MathDelegate mathDelegate2 = (a, b, c) =>
            {
                //Решается квадротное уравнение и возвращается сумма корней
                double D = Math.Pow(b, 2) - 4 * a * c;
                double x1 = 0, x2 = 0;

                if (D < 0)
                {
                    Console.WriteLine("Квадротное уравнение не имеет корней");
                }
                else if (D == 0)
                {
                    x1 = -b / (2 * a);
                }
                else
                {
                    x1 = (-b + Math.Sqrt(D)) / (2 * a);
                    x2 = (-b - Math.Sqrt(D)) / (2 * a);
                }

                return x1 + x2;
            };

            Console.WriteLine($"Сумма корней 2 -14 24 = {mathDelegate2.Invoke(2, -14, 24)}\n");
        }
    }
}
