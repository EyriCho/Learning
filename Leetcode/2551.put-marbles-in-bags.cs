/*
 * @lc app=leetcode id=2551 lang=csharp
 *
 * [2551] Put Marbles in Bags
 */

// @lc code=start
public class Solution {
    public long PutMarbles(int[] weights, int k) {
        if (weights.Length == k)
        {
            return 0;
        }

        for (int i = 1; i < weights.Length; i++)
        {
            weights[i - 1] += weights[i];
        }

        Array.Sort(weights, 0, weights.Length - 1);

        long result = 0L;
        for (int i = 0 ; i < k - 1; i++)
        {
            result += weights[weights.Length - 2 - i] - weights[i];
        }

        return result;
    }
}
// @lc code=end

