namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    /// <summary>
    /// 코딩테스트 연습 -> 정렬 -> H-Index
    /// https://programmers.co.kr/learn/courses/30/lessons/42747?language=csharp
    /// </summary>
    public sealed class HIndex
    {
        public int Solution(int[] citations)
        {
            int hIndex = 0;
            for (int i = citations.Length; i > 0; --i)
            {
                int lessCount = 0;
                int moreCount = 0;
                for (int j = 0; j < citations.Length; ++j)
                {
                    if (citations[j] <= i)
                    {
                        ++lessCount;
                    }
                    if (citations[j] >= i)
                    {
                        ++moreCount;
                    }

                    if (lessCount > i)
                    {
                        break;
                    }
                }

                if (lessCount <= i && moreCount >= i)
                {
                    hIndex = i;

                    break;
                }
            }

            return hIndex;
        }
    }
}
