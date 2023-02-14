
int sum = 0;
int[] results = new int[2];

int[] TwoSum(int[] nums, int target)
{

    for (int i = 0; i < nums.Length; i++)
    {
        if (nums[i] <= target)
        {
            for (int j = 0; j < nums.Length; j++)
            {

                sum = nums[i] + nums[j];

                if (sum == target && i != j)
                {
                    results[0] = i;
                    results[1] = j;
                    return results;
                }

            }
        }
    }

    return results;
}
int[] cyferki = { 0, 4, 3, 0 };
TwoSum(cyferki, 0);
Console.WriteLine(results);