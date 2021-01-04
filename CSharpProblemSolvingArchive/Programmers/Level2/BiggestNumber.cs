using System;
using System.Linq;
using System.Text;

namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    /// <summary>
    /// 코딩테스트 연습 -> 정렬 -> 가장 큰 수
    /// https://programmers.co.kr/learn/courses/30/lessons/42746?language=csharp
    /// </summary>
    public sealed class BiggestNumber
    {
        public string Solution(int[] numbers)
        {
            string[] numList = numbers
                .Select(n => n.ToString())
                .ToArray();

            Array.Sort<string>(numList, (o1, o2) => (o2 + o1).CompareTo(o1 + o2));

            if (numList[0].Equals("0")) return "0";

            StringBuilder answer = new StringBuilder();
            foreach (string item in numList)
            {
                answer.Append(item);
            }

            return answer.ToString();
        }
    }
}
