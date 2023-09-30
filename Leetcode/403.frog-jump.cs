/*
 * @lc app=leetcode id=403 lang=csharp
 *
 * [403] Frog Jump
 */

// @lc code=start
public class Solution {
    public bool CanCross(int[] stones) {
        var dp = new Dictionary<int, bool>();

        bool Dfs(int pos, int k)
        {
            var key = pos + k * 10_000;
            if (dp.ContainsKey(key))
            {
                return dp[key];
            }

            for (int i = pos + 1; i < stones.Length; i++)
            {
                int step = stones[i] - stones[pos];
                if (step < k - 1)
                {
                    continue;
                }

                if (step > k + 1)
                {
                    dp[key] = false;
                    return false;
                }

                if (Dfs(i, step))
                {
                    dp[key] = true;
                    return true;
                }
            }

            dp[key] = pos == stones.Length - 1;
            return dp[key];
        }

        return Dfs(0, 0);
    }
}
// @lc code=end

