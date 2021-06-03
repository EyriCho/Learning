/*
 * @lc app=leetcode id=943 lang=csharp
 *
 * [943] Find the Shortest Superstring
 */

// @lc code=start
public class Solution {
    public string ShortestSuperstring(string[] words) {
        var overlap = new int[words.Length, words.Length];
        for (int i = 0; i < words.Length; i++)
            for (int j = 0; j < words.Length; j++)
            {
                if (i == j)
                    continue;
                
                for (int k = Math.Min(words[i].Length, words[j].Length); k >= 0; k--)
                    if (words[i][(words[i].Length - k)..] == words[j][0..k])
                    {
                        overlap[i, j] = k;
                        break;
                    }
            }
        
        var last = 1 << words.Length;
        var dp = new string[last, words.Length];
        
        for (int i = 0; i < words.Length; i++)
            dp[(1 << i), i] = words[i];
        for (int mask = 1; mask < last; mask++)
        {
            for (int j = 0; j < words.Length; j++)
            {
                if ((mask & 1 << j) == 0)
                    continue;
                
                for (int i = 0; i < words.Length; i++)
                {
                    if (i == j || (mask & 1 << i) == 0)
                        continue;
                    string t = dp[(mask ^ 1 << j), i] + words[j][overlap[i, j]..];
                    if (dp[mask, j] == null || dp[mask, j].Length > t.Length)
                        dp[mask, j] = t;
                }
            }
        }
        
        last--;
        var result = dp[last, 0];
        for (int i = 1; i < words.Length; i++)
            if (dp[last, i].Length < result.Length)
                result = dp[last, i];
        
        return result;
    }
}
// @lc code=end

