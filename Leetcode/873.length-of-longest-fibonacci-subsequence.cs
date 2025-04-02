/*
 * @lc app=leetcode id=873 lang=csharp
 *
 * [873] Length of Longest Fibonacci Subsequence
 */

// @lc code=start
public class Solution {
    public int LenLongestFibSubseq(int[] arr) {
        Dictionary<int, int> dict = new ();
        int result = 0,
            diff = 0,
            diffIndex = 0;
        int[,] dp = new int[arr.Length, arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            dict[arr[i]] = i;

            for (int j = 0; j < i; j++)
            {
                diff = arr[i] - arr[j];
                if (dict.ContainsKey(diff))
                {
                    diffIndex = dict[diff];
                }
                else
                {
                    diffIndex = -1;
                }

                if (diff < arr[j] && diffIndex >= 0)
                {
                    dp[j, i] = dp[diffIndex, j] + 1;
                }
                else
                {
                    dp[j, i] = 2;
                }

                result = Math.Max(result, dp[j, i]);
            }
        }
        
        return result > 2 ? result : 0;
    }
}
// @lc code=end

