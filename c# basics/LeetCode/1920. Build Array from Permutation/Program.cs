//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Reflection.Metadata.Ecma335;

int[] BuildArray(int[] nums)
{

    int[] result = new int[nums.Length];
    int size = result.Length;

    for (int i = 0; i < size; i++)
    {
        result[i] = nums[nums[i]];
    }

    return result;
}


