using System;

namespace CSharpProblemSolvingArchive.LeetCode.Easy
{
    /// <summary>
    /// 1534. Count Good Triplets
    /// https://leetcode.com/problems/count-good-triplets/
    /// </summary>
    public sealed class Q1534
    {
        public int CountGoodTriplets(int[] arr, int a, int b, int c)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 2; ++i)
                for (int j = i + 1; j < arr.Length - 1; ++j)
                    for (int k = j + 1; k < arr.Length; ++k)
                        if (Math.Abs(arr[i] - arr[j]) <= a && Math.Abs(arr[j] - arr[k]) <= b && Math.Abs(arr[i] - arr[k]) <= c)
                            ++count;

            return count;
        }
    }
}
