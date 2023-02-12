
int count = 0;
int i;
int MinimumOperations(int[] nums)
{
    for (i = 0; i < (nums.Length / 2); i++)
    {
        Console.WriteLine(nums[i]);
    }

    if (nums.Length % 2 == 0)
    {
        for (i = 1; i <= nums.Length / 2; i++)
        {
            if (nums[(nums.Length / 2) + i - 1] == nums[(nums.Length / 2) - i])
            {
                Console.WriteLine(nums[(nums.Length / 2) + i - 1]);
                continue;
            }

            else
            {
                nums[(nums.Length / 2) + i - 1] = nums[(nums.Length / 2) - i];
                Console.WriteLine(nums[(nums.Length / 2) + i - 1]);
                count++;
            }
        }
    }

    if (nums.Length % 2 != 0)
    {
        if (nums[(nums.Length / 2)] != nums[0])
        {
            nums[(nums.Length / 2)] = nums[0];
            Console.WriteLine(nums[(nums.Length / 2)]);
            count++;
        }

        for (i = 1; i <= nums.Length / 2; i++)
        {
            if (nums[(nums.Length / 2) + i] == nums[(nums.Length / 2) - i])
            {
                Console.WriteLine(nums[(nums.Length / 2 + i)]);
                continue;
            }

            else
            {
                nums[(nums.Length / 2) + i] = nums[(nums.Length / 2) - i];
                Console.WriteLine(nums[(nums.Length / 2) + i]);
                count++;
            }

        }

    }
    return count;

}

//              0, 1, 2, 3, 4, 5
int[] input = { 3, 1, 3, 2, 4, 3 };
MinimumOperations(input);
Console.WriteLine(count);
