/*
 * @lc app=leetcode id=2818 lang=csharp
 *
 * [2818] Apply Operations to Maximize Score
 */

// @lc code=start
public class Solution {
    public int MaximumScore(IList<int> nums, int k) {
        int[] scores = new int[nums.Count];
        int num = 0,
            sqrt = 0,
            s = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            num = nums[i];
            sqrt = (int)Math.Sqrt(nums[i]);
            s = 0;
            for (int j = 2; j <= sqrt; j++)
            {
                if (num % j == 0)
                {
                    s++;
                }

                while (num % j == 0)
                {
                    num /= j;
                }
            }
            if (num >= 2)
            {
                s++;
            }
            scores[i] = s;
        }

        int[] array = new int[scores.Length],
            left = new int[scores.Length],
            right = new int[scores.Length];
        Array.Fill(right, scores.Length);
        Stack<int> stack = new ();
        for (int i = 0; i < scores.Length; i++)
        {
            while (stack.Count > 0 &&
                scores[i] > scores[stack.Peek()])
            {
                right[stack.Pop()] = i;
            }
            left[i] = stack.Count == 0 ? -1 : stack.Peek();

            stack.Push(i);
        }

        long[] subarrays = new long[scores.Length];
        for (int i = 0; i < scores.Length; i++)
        {
            array[i] = nums[i];
            subarrays[i] = (long)(i - left[i]) * (right[i] - i);
        }
        Array.Sort(array, subarrays, Comparer<int>.Create((a, b) => b.CompareTo(a)));

        long ModPow(long v, long e)
        {
            long rst = 1L;
            v %= 1_000_000_007;
            while (e > 0)
            {
                if ((e & 1) == 1)
                {
                    rst = rst * v % 1_000_000_007;
                }
                v = v * v % 1_000_000_007;
                e >>= 1;
            }
            return rst;
        }

        long result = 1L;
        int idx = 0;
        while (k > 0)
        {
            subarrays[idx] = Math.Min(subarrays[idx], k);
            result = (result * ModPow(array[idx], subarrays[idx])) % 1_000_000_007;
            k -= (int)subarrays[idx];
        }

        return (int)result;
    }
}
// @lc code=end

