/*
 * @lc app=leetcode id=3186 lang=csharp
 *
 * [3186] Maximum Total Damage With Spell Casting
 */

// @lc code=start
public class Solution {
    public long MaximumTotalDamage(int[] power) {
        Dictionary<int, long> dict = new ();
        long count = 0;
        foreach (int p in power)
        {
            dict.TryGetValue(p, out count);
            dict[p] = count + 1L;
        }

        int[] powers = dict.Keys.ToArray();
        Array.Sort(powers);
        long[] dp = new long[powers.Length];
        dp[0] = powers[0] * dict[powers[0]];
        int l = 0, m = 0, r = 0,
            found = 0;
        for (int i = 1; i < powers.Length; i++)
        {
            dp[i] = powers[i] * dict[powers[i]];
            l = 0;
            r = i - 1;
            found = -1;
            while (l <= r)
            {
                m = (l + r) >> 1;
                if (powers[m] <= powers[i] - 3)
                {
                    found = m;
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            if (found >= 0)
            {
                dp[i] += dp[found];
            }

            dp[i] = Math.Max(dp[i], dp[i - 1]);
        }
        
        return dp[^1];
    }
}
// @lc code=end

