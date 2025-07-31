/*
 * @lc app=leetcode id=3333 lang=csharp
 *
 * [3333] Find the Original Typed String II
 */

// @lc code=start
public class Solution {
    public int PossibleStringCount(string word, int k) {
        if (word.Length < k)
        {
            return 0;
        }
        else if (word.Length == k)
        {
            return 1;
        }

        List<int> groups = new ();
        int i = 0, l = 0;
        long total = 1L;
        while (i < word.Length)
        {
            l = i;
            while (i < word.Length && word[i] == word[l])
            {
                i++;
            }
            groups.Add(i - l);
            total = (total * (i - l)) % 1_000_000_007L;

        }

        if (groups.Count >= k)
        {
            return (int)total;
        }

        int[] dp = new int[k],
            next = new int[k],
            temp = null;
        dp[0] = 1;
        long sum = 0L;

        foreach (int g in groups)
        {
            sum = 0L;
            for (int s = 0; s < k; s++)
            {
                if (s > 0)
                {
                    sum = (sum + dp[s - 1]) % 1_000_000_007L;
                }
                if (s > g)
                {
                    sum = (sum - dp[s - g - 1] + 1_000_000_007L) % 1_000_000_007L;
                }

                next[s] = (int)sum;
            }


            temp = dp;
            dp = next;
            next = temp;
        }

        sum = 0L;
        for (int g = groups.Count; g < k; g++)
        {
            sum = (sum + dp[g]) % 1_000_000_007L;
        }

        return (int)((total - sum + 1_000_000_007L) % 1_000_000_007L);
    }
}
// @lc code=end

