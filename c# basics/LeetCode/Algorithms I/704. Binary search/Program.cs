
int index = 0; ;
int Search(int[] nums, int target)
{
    foreach (int x in nums)
    {

        if (x == target)
        {
            index = Array.IndexOf(nums, x);
            break;
        }

    }

    if (index != Array.IndexOf(nums, target))
    {
        index = -1;
    }
    return index;
}

int[] numery = { -1, 0, 3, 5, 9, 12 };

Search(numery, 2);