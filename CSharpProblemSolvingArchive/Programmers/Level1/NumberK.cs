using System.Linq;

namespace CSharpProblemSolvingArchive.Programmers.Level1
{
    /// <summary>
    /// 코딩테스트 연습 -> 정렬 -> K번째수
    /// https://programmers.co.kr/learn/courses/30/lessons/42748?language=csharp
    /// </summary>
    public sealed class NumberK
    {
        public int[] Solution(int[] array, int[,] commands)
        {
            int length = commands.Length / 3;
            int[] answer = new int[length];
            for (int i = 0; i < length; ++i)
            {
                int a = commands[i, 0];
                int b = commands[i, 1];
                int[] cropArray = new int[b - a + 1];
                int lala = 0;
                for (int j = a - 1; j < b; ++j)
                {
                    cropArray[lala] = array[j];
                    ++lala;
                }

                cropArray = cropArray.OrderBy(c => c).ToArray();
                answer[i] = cropArray[commands[i, 2] - 1];
            }

            return answer;
        }
    }
}
