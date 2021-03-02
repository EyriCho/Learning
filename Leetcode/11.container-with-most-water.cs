/*
 * @lc app=leetcode id=11 lang=csharp
 *
 * [11] Container With Most Water
 */

// @lc code=start
public class Solution {
    public int MaxArea(int[] height) {
        int l = 0, r = height.Length - 1,
            result = 0;
        
        while (l != r)
        {
            if (height[l] < height[r])
            {
                result = Math.Max(result, height[l] * (r - l));
                l++;
            }
            else
            {
                result = Math.Max(result, height[r] * (r - l));
                r--;
            }
        }
        
        return result;
    }
}
// @lc code=end

