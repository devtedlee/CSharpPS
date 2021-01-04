using System.Collections.Generic;

namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    /// <summary>
    /// 코딩테스트 연습 -> 스택/큐 -> 기능개발
    /// https://programmers.co.kr/learn/courses/30/lessons/42586?language=csharp
    /// </summary>
    public sealed class FunctionDevelopment
    {
        public int[] Solution(int[] progresses, int[] speeds)
        {
            List<int> answer = new List<int>();

            int currentCompleteDays = 0;
            int taskCount = 0;
            for (int i = 0; i < progresses.Length; ++i)
            {
                int remainProgress = 100 - progresses[i];
                int completeDays = remainProgress / speeds[i];

                if (remainProgress % speeds[i] > 0)
                    completeDays += 1;

                if (currentCompleteDays == 0)
                {
                    currentCompleteDays = completeDays;
                }

                if (currentCompleteDays < completeDays)
                {
                    answer.Add(taskCount);
                    taskCount = 0;
                    currentCompleteDays = completeDays;
                }

                ++taskCount;
            }

            if (taskCount != 0)
            {
                answer.Add(taskCount);
            }

            return answer.ToArray();
        }
    }
}
