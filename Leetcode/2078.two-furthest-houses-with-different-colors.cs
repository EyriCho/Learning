/*
 * @lc app=leetcode id=2078 lang=csharp
 *
 * [2078] Two Furthest Houses With Different Colors
 */

// @lc code=start
public class Solution {
    public int MaxDistance(int[] colors) {
        if (colors[0] != colors[^1])
        {
            return colors.Length - 1;
        }

        int last = colors.Length - 1;

        for (int i = 1; i < last; i++)
        {
            if (colors[0] != colors[colors.Length - 1 - i] ||
                colors[^1] != colors[i])
            {
                return colors.Length - 1 - i;
            }
        }

        return 0;
    }
}
// @lc code=end

