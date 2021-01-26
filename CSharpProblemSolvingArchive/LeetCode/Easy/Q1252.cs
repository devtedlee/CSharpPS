namespace CSharpProblemSolvingArchive.LeetCode.Easy
{
    /// <summary>
    /// 1252. Cells with Odd Values in a Matrix
    /// https://leetcode.com/problems/cells-with-odd-values-in-a-matrix/
    /// </summary>
    public sealed class Q1252
    {
        public int OddCells(int n, int m, int[][] indices)
        {
            return solution2(n, m, indices);
        }

        private int solution1(int n, int m, int[][] indices)
        {
            var arr = new int[n, m];
            for (int i = 0; i < indices.Length; ++i)
            {
                int row = indices[i][0];
                int col = indices[i][1];
                for (int ri = 0; ri < n; ++ri)
                    ++arr[ri, col];

                for (int ci = 0; ci < m; ++ci)
                    ++arr[row, ci];
            }

            int oddCount = 0;
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    if (arr[i, j] % 2 != 0)
                        ++oddCount;

            return oddCount;
        }

        private int solution2(int n, int m, int[][] indices)
        {
            var rows = new int[n];
            var cols = new int[m];
            foreach (int[] idxs in indices)
            {
                ++rows[idxs[0]];
                ++cols[idxs[1]];
            }

            int oddCount = 0;
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                    if ((rows[i] + cols[j]) % 2 != 0)
                        ++oddCount;

            return oddCount;
        }
    }
}
