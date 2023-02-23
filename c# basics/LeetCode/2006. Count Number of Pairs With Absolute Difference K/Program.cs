//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Given an integer array nums and an integer k, return the number of pairs (i, j) where i<j such that |nums[i] - nums[j]| == k.

//The value of |x| is defined as:

//x if x >= 0.
//- x if x < 0.


/// <summary>
/// mem 92.41, runtime 11.72 :(
/// </summary>
//public class Solution
//{
//    public int CountKDifference(int[] nums, int k)
//    {

//        int size = nums.Length;
//        int count = 0;

//        for (int i=0; i<size;i++)
//        {
//            for(int j=0;j<size;j++)
//            {
//                if (nums[i] - nums[j] ==k)
//                    count++;
//            }
//        }

//        return count;
//    }
//}


