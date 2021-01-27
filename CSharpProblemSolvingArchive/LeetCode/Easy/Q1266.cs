using System;

namespace CSharpProblemSolvingArchive.LeetCode.Easy
{
    /// <summary>
    /// 1266. Minimum Time Visiting All Points
    /// https://leetcode.com/problems/minimum-time-visiting-all-points/
    /// </summary>
    public sealed class Q1266
    {
        public int MinTimeToVisitAllPoints(int[][] points)
        {
            int count = 0;
            for (int i = 1; i < points.Length; ++i)
                count += Math.Max(Math.Abs(points[i - 1][0] - points[i][0]), Math.Abs(points[i - 1][1] - points[i][1]));

            return count;
        }
    }
}
