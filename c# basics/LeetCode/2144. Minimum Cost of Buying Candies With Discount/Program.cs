//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int MinimumCost(int[] cost)
{
    Array.Sort(cost);
    Array.Reverse(cost);

    int sum = 0;

    for (int i = 0;i < cost.Length; i++)
    {

        if (i % 3 == 2)
            continue;

        sum += cost[i];

    }

    return sum;
}

int[] cost =
{
    6,
    5,
    7,
    9,
    2,
    2
};
//0 1 2 3 4 5
//9,7,6,5,2,2
MinimumCost(cost);

