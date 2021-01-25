using System.Text;

namespace CSharpProblemSolvingArchive.LeetCode.Easy
{
    /// <summary>
    /// 1295. Find Numbers with Even Number of Digits
    /// https://leetcode.com/problems/find-numbers-with-even-number-of-digits/
    /// </summary>
    public sealed class Q1295
    {
        public int FindNumbers(int[] nums)
        {
            int evenCount = 0;
            StringBuilder sb = new StringBuilder();
            foreach (int num in nums)
            {
                sb.Append(num);
                if (sb.Length % 2 == 0)
                    ++evenCount;
                sb.Clear();
            }

            return evenCount;
        }
    }
}
