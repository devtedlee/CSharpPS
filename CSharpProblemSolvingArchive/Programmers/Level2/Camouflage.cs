using System.Collections.Generic;

namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    /// <summary>
    /// 코딩테스트 연습 -> 해시 -> 위장
    /// https://programmers.co.kr/learn/courses/30/lessons/42578?language=csharp
    /// </summary>
    public sealed class Camouflage
    {
        public int Solution(string[,] clothes)
        {
            Dictionary<string, int> clothMap = new Dictionary<string, int>();
            int length = clothes.Length / 2;
            for (int i = 0; i < length; ++i)
            {
                if (!clothMap.TryAdd(clothes[i, 1], 1))
                {
                    clothMap[clothes[i, 1]] = clothMap[clothes[i, 1]] + 1;
                }
            }

            List<int> nums = new List<int>();
            foreach (var cloth in clothMap)
            {
                nums.Add(cloth.Value);
            }

            int sum = 0;
            for (int i = 0; i < nums.Count; ++i)
            {
                int val1 = nums[i];
                sum += val1;
                for (int j = i + 1; j < nums.Count; ++j)
                {
                    int val2 = val1 * nums[j];
                    sum += val2;
                    val1 += val2;
                }
            }

            return sum;
        }
    }
}
