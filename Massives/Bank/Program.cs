using System;
using System.Runtime.CompilerServices;

namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report[,] reports = new Report[2, 3];
            reports[0, 0] = new Report(0, 100);
            reports[0, 1] = new Report(1, 1000);
            reports[0, 2] = new Report(2, 83000);
            reports[1, 0] = new Report(3, 32000);
            reports[1, 1] = new Report(4, 4000);
            reports[1, 2] = new Report(5, 5000);

            Bank bank = new Bank(99000000, reports);

            Console.WriteLine($"{bank[0, 0].Money}");

            decimal money = (decimal)bank;
        }
    }
}
