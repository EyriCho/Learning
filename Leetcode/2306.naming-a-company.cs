/*
 * @lc app=leetcode id=2306 lang=csharp
 *
 * [2306] Naming a Company
 */

// @lc code=start
public class Solution {
    public long DistinctNames(string[] ideas) {
        var set = new HashSet<string>(ideas);

        var dp = new long[26, 26];
        foreach (var idea in ideas)
        {
            int i = idea[0] - 'a';
            var array = idea.ToCharArray();
            for (int j = 0; j < 26; j++)
            {
                array[0] = (char)('a' + j);
                var s = new string(array);
                if (!set.Contains(s))
                {
                    dp[i, j]++;
                }
            }
        }

        var result = 0L;
        for (int i = 0; i < 26; i++)
        {
            for (int j = 0; j < 26; j++)
            {
                result += dp[i, j] * dp[j, i];
            }
        }

        return result;
    }
}
// @lc code=end

