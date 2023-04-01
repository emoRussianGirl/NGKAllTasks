namespace NGKOperators
{
    internal class Program
    {
        static void Main()
        {
            House house1 = new House(3, 40, 500000);
            House house2 = new House(5, 60, 400000);
            House house3 = new House(3, 40, 500000);
            House house4 = null!;

            Console.WriteLine(house1.SquareFootage > house4?.SquareFootage);

            Console.WriteLine(house1);
            Console.WriteLine(house2);
            Console.WriteLine(house3);
            Console.WriteLine();

            Console.WriteLine($"house1 equals house3: {house1.Equals(house3)}");
            Console.WriteLine($"house1 equals house2: {house1.Equals(house2)}");
            Console.WriteLine();

            Console.WriteLine($"house1 + house2 = {house1 + house2}");
            Console.WriteLine($"house2 - house1 = {house2 - house1}");
            Console.WriteLine($"house1 * 2 = {house1 * 2}");
            Console.WriteLine($"house2 / 5 = {house2 / 5}");
            Console.WriteLine();

            Console.WriteLine($"house1 > house2: {house1 > house2}");
            Console.WriteLine($"house1 < house2: {house1 < house2}");
            Console.WriteLine($"house1 >= house3: {house1 >= house3}");
            Console.WriteLine($"house1 <= house2: {house1 <= house2}");
            Console.WriteLine($"house1 == house3: {house1 == house3}");
            Console.WriteLine($"house1 != house2: {house1 != house2}");
        }
    }
}