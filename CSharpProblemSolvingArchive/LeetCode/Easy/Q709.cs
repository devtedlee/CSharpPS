using System.Text;

namespace CSharpProblemSolvingArchive.LeetCode.Easy
{
    /// <summary>
    /// 709. To Lower Case
    /// https://leetcode.com/problems/to-lower-case/
    /// </summary>
    public sealed class Q709
    {
        public string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char s in str)
            {
                if (s >= 'A' && s <= 'Z')
                    sb.Append((char)(s + 32));
                else
                    sb.Append(s);
            }

            return sb.ToString();
        }
    }
}
