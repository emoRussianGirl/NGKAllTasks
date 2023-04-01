namespace Static
{
    class Program
    {
        static void findDigits(int M, int N, out int MOut, out int NOut)
        {
            MOut = M % 10;
            NOut = N % 10;
            int n = N;

            while (n > 0)
            {
                NOut = n % 10;
                n = (n - NOut) / 10;
            }
        }
        static void threePow(ref double n1, ref double n2, ref double n3)
        {
            n1 = n1 > 0 ? Math.Pow(n1, 2.0) : Math.Pow(n1, 4.0);
            n2 = n2 > 0 ? Math.Pow(n2, 2.0) : Math.Pow(n2, 4.0);
            n3 = n3 > 0 ? Math.Pow(n3, 2.0) : Math.Pow(n3, 4.0);
        }
        static int summCubes(int n)
        {
            if (n < 1) throw new ArgumentException("неверный аргумент");
            if (n == 1) return 1;

            return (int)Math.Pow(Convert.ToDouble(n), 3.0) + summCubes(n - 1);
        }
        static void Main()
        {
            //1
            //int M, N;
            //findDigits(103, 2048, out M, out N);
            //Console.WriteLine("M = {0}, N = {1}", M, N);

            //2
            //double n1 = Convert.ToDouble(Console.ReadLine());
            //double n2 = Convert.ToDouble(Console.ReadLine());
            //double n3 = Convert.ToDouble(Console.ReadLine());

            //threePow(ref n1, ref n2, ref n3);
            //Console.WriteLine("n1 = {0}; n2 = {1}; n3 = {2}", n1, n2, n3);

            //3
            //int n = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(summCubes(n));
        }
    }
}