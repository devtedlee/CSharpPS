namespace CSharpProblemSolvingArchive.Programmers.Level2
{
    public sealed class TargetNumber
    {
        public int Solution(int[] numbers, int target)
        {
            int result = getCountRecursive(numbers, target, 0, 0);

            return result;
        }

        private int getCountRecursive(int[] numbers, int target, int index, int sum)
        {
            if (index >= numbers.Length)
            {
                if (target == sum) return 1;

                return 0;
            }

            return getCountRecursive(numbers, target, index + 1, sum + numbers[index]) + getCountRecursive(numbers, target, index + 1, sum - numbers[index]);
        }
    }
}
