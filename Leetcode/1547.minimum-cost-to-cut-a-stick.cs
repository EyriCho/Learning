/*
 * @lc app=leetcode id=1547 lang=csharp
 *
 * [1547] Minimum Cost to Cut a Stick
 */

// @lc code=start
public class Solution {
    public int MinCost(int n, int[] cuts) {
        Array.Sort(cuts);
        var array = new int[cuts.Length + 2];
        array[0] = 0;
        for (int i = 0; i < cuts.Length; i++)
        {
            array[i + 1] = cuts[i];
        }
        array[cuts.Length + 1] = n;

        var dp = new int[array.Length, array.Length];

        for (int dist = 2; dist < array.Length; dist++)
        {
            for (int i = 0; i + dist < array.Length; i++)
            {
                int j = i + dist;
                dp[i, j] = int.MaxValue;

                for (int k = i + 1; k < j; k++)
                {
                    dp[i, j] = Math.Min(dp[i, j], dp[i, k] + dp[k, j] + array[j] - array[i]);
                }
            }
        }

        return dp[0, array.Length - 1];
    }
}
// @lc code=end

