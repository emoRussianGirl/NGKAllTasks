using System;

namespace DateTimeJope
{
    public class Program
    {
        static void Main()
        {
            DateTimeProcess.Process();
        }
    }

    public class DateTimeProcess
    {
        public static void Process()
        {
            //Экземпляр с датой и времени сейчас
            DateTime dt1 = DateTime.Now;

            Console.WriteLine(dt1);

            //Разные форматы.
            Console.WriteLine($"Year: {dt1.Year}");
            Console.WriteLine($"Mounth: {dt1.Month}");
            Console.WriteLine($"Days: {dt1.Day}");
            Console.WriteLine($"{dt1.DayOfWeek}");
            Console.WriteLine($"{dt1.DayOfYear}");
            Console.WriteLine($"Hours: {dt1.Hour}");
            Console.WriteLine($"Minutes: {dt1.Minute}");
            Console.WriteLine($"Seconds: {dt1.Second}");

            //Экземляры TimeSpan и сумма разностей
            DateTime now = DateTime.Now;
            DateTime ts1 = new DateTime(2023, 04, 01);
            TimeSpan minus = now - ts1;
            TimeSpan plus = new TimeSpan(1, 0, 0, 0);
            DateTime result = now.Add(plus);

            Console.WriteLine($"{now} - {ts1} = {minus}");
            Console.WriteLine($"{now} + {plus} = {result}");

            //Др
            DateTime birthDate = new DateTime(2004, 4, 8);
            TimeSpan bd = birthDate.Subtract(dt1);
            Console.WriteLine($"My age in years: {Math.Floor((double)(bd.Days / 365))}");
            Console.WriteLine($"My age in mouth: {Math.Floor((double)(bd.Days / 365) + 12)}");
            Console.WriteLine($"My age in days: {bd.Days}");
        }
    }
}
