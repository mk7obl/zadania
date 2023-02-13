public class Solution : VersionControl
{
    int index;
    int low = 1;
    public int FirstBadVersion(int n)
    {

        if (IsBadVersion(low) == true)
        {
            index = low;
        }

        if (index != low)
        {
            for (int i = n; i >= 0; i--)
            {

                bool ans = IsBadVersion(i);

                if (ans == false)
                {
                    index = i + 1;
                    break;
                }

            }
        }
        return index;
    }
}