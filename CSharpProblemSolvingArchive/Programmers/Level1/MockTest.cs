using System.Collections.Generic;

namespace CSharpProblemSolvingArchive.Programmers.Level1
{
    /// <summary>
    /// 코딩테스트 연습 -> 완전탐색 -> 모의고사
    /// </summary>
    public sealed class MockTest
    {
        public int[] solution(int[] answers)
        {
            int[] giveUpMath1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] giveUpMath2 = new int[8] { 2, 1, 2, 3, 2, 4, 2, 5 };
            int[] giveUpMath3 = new int[10] { 3, 3, 1, 1, 2, 2, 4, 4, 5, 5 };

            int[] scores = new int[3];
            for (int i = 0; i < answers.Length; ++i)
            {
                int currentAnswer = answers[i];

                if (currentAnswer == giveUpMath1[i % 5]) ++scores[0];

                if (currentAnswer == giveUpMath2[i % 8]) ++scores[1];

                if (currentAnswer == giveUpMath3[i % 10]) ++scores[2];
            }

            List<int> result = new List<int>(3);
            result.Add(1);
            int max = scores[0];
            for (int i = 1; i < scores.Length; ++i)
            {
                if (max < scores[i])
                {
                    max = scores[i];
                    result.Clear();
                    result.Add(i + 1);
                }
                else if (max == scores[i])
                {
                    result.Add(i + 1);
                }
            }

            return result.ToArray();
        }
    }
}
