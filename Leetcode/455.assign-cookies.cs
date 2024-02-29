/*
 * @lc app=leetcode id=455 lang=csharp
 *
 * [455] Assign Cookies
 */

// @lc code=start
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);

        int child = 0,
            cookie = 0,
            result = 0;

        while (child < g.Length && cookie < s.Length)
        {
            if (g[child] <= s[cookie])
            {
                child++;
                result++;
            }
            
            cookie++;
        }

        return result;
    }
}
// @lc code=end

