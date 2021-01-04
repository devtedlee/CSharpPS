using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    public sealed class FIndPrimeNumbers
    {
        private List<int> mPerms;

        public FIndPrimeNumbers()
        {
            mPerms = new List<int>();
        }

        public int Solution(string numbers)
        {
            // 1. numbers의 모든 조합 만들기
            var arr = numbers.ToArray();
            for (int i = 0; i < numbers.Length; ++i)
            {
                PermutationRecursive(arr, 0, numbers.Length, 1 + i);
            }

            // 2. 1에서 만든 모든 조합 중 최대 값 내에서 가능한 소수 조합 만들기
            var isPrimes = getPrimeNumbers2(mPerms.Max());

            // 3. 1과 2의 컬렉션에서 일치하는 배열 찾아 counting
            int count = 0;
            foreach (int num in mPerms)
            {
                if (isPrimes[num])
                    ++count;
            }

            return count;
        }

        private void PermutationRecursive(char[] numbers, int depth, int n, int r)
        {
            if (depth == r)
            {
                string numStr = new string(numbers);
                int num = int.Parse(numStr.Substring(0, r));
                if (!mPerms.Contains(num))
                    mPerms.Add(num);
                return;
            }

            for (int i = depth; i < n; ++i)
            {
                char temp = numbers[depth];
                numbers[depth] = numbers[i];
                numbers[i] = temp;

                PermutationRecursive(numbers, depth + 1, n, r);

                temp = numbers[i];
                numbers[i] = numbers[depth];
                numbers[depth] = temp;
            }
        }

        //에라토스테네스의 체
        private bool[] getPrimeNumbers2(int target)
        {
            bool[] nums = new bool[target + 1];
            for (int i = 2; i <= target; ++i)
                nums[i] = true;

            for (int i = 2; i * i <= target; ++i)
            {
                if (nums[i])
                {
                    int j = i * i;
                    while (j <= target)
                    {
                        nums[j] = false;

                        j += i;
                    }
                }
            }

            return nums;
        }
    }
}
