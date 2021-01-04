using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpProblemSolvingArchive.Programmers.Level3
{
    /// <summary>
    /// 코딩테스트 연습 -> 해시 -> 베스트앨범
    /// https://programmers.co.kr/learn/courses/30/lessons/42579?language=csharp
    /// </summary>
    public sealed class BestAlbum
    {
        public int[] Solution(string[] genres, int[] plays)
        {

            Dictionary<string, List<Tuple<int, int>>> dic = new Dictionary<string, List<Tuple<int, int>>>();
            for (int i = 0; i < genres.Length; ++i)
            {
                dic.TryAdd(genres[i], new List<Tuple<int, int>>());

                dic[genres[i]].Add(new Tuple<int, int>(plays[i], i));
            }

            List<List<Tuple<int, int>>> list = dic
                .Select(d => d.Value
                    .OrderByDescending(i => i.Item1)
                    .ToList())
                .OrderByDescending(l => l.Sum(i => i.Item1))
                .ToList();

            List<int> answer = new List<int>();
            foreach (var item in list)
            {
                answer.Add(item[0].Item2);
                if (item.Count > 1)
                {
                    answer.Add(item[1].Item2);
                }
            }

            return answer.ToArray();
        }
    }
}
