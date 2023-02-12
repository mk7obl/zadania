internal class Program
{

    // just a reminder
    public static void Main(string[] args)
    {
        Console.WriteLine("List with random numbers");

        int i = 0;
        var numbers = new List<int>();
        Random random = new Random();

        numbers.Capacity = random.Next(1, 10);
        Console.WriteLine("Number of elements:{0}", numbers.Capacity);


        while (i < numbers.Capacity)
        {
            numbers.Add(random.Next(1, 100));
            Console.WriteLine("Element number {0}: {1}", i, numbers[i].ToString());
            i++;
        }

        Console.WriteLine(string.Join(",", numbers));
    }
}