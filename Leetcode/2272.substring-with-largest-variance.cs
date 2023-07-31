/*
 * @lc app=leetcode id=2272 lang=csharp
 *
 * [2272] Substring with Largest Variance
 */

// @lc code=start
public class Solution {
    public int LargestVariance(string s) {
        var result = 0;
        for (char i = 'a'; i <= 'z'; i++)
        {
            for (char j = 'a'; j <= 'z'; j++)
            {
                if (i == j)
                {
                    continue;
                }

                int diff = 0,
                    diffWithB = -s.Length;

                for (int k = 0; k < s.Length; k++)
                {
                    if (s[k] == i)
                    {
                        diff++;
                        diffWithB++;
                    }
                    else if (s[k] == j)
                    {
                        diff--;
                        diffWithB = diff;
                        diff = Math.Max(diff, 0);
                    }

                    result = Math.Max(result, diffWithB);
                }
            }
        }
        return result;
    }
}
// @lc code=end