namespace TaskNo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Islam's Carpet Cleaning Service");
            int smallRoom = 25;
            int largeRoom = 35;
            double taxRate = 0.06;
            Console.WriteLine("Enter Number of small carpets");
            int numSmallCarpet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number of large carpets");
            int numLargeCarpet = Convert.ToInt32(Console.ReadLine());
            double cost = (smallRoom * numSmallCarpet) + (largeRoom * numLargeCarpet);
            double tax = cost * taxRate;
            Console.WriteLine($"number of small carpets : {numSmallCarpet}");
            Console.WriteLine($"number of large carpets : {numLargeCarpet}");
            Console.WriteLine($"Price per small room : {smallRoom}");
            Console.WriteLine($"Price per large room : {largeRoom}");
            Console.WriteLine($"Cost : {cost}");
            Console.WriteLine($"Tax : {tax}");
            Console.WriteLine("==========================");
            Console.WriteLine($"Total estimate : {cost + tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}
