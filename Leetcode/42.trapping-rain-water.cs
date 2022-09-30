/*
 * @lc app=leetcode id=42 lang=csharp
 *
 * [42] Trapping Rain Water
 */

// @lc code=start
public class Solution {
    public int Trap(int[] height) {
        int l = 0,
            r = height.Length - 1;
        int lMax = 0, rMax = 0;
        int result = 0;
        
        while (l < r)
        {
            if (height[l] < height[r])
            {
                if (height[l] > lMax)
                {
                    lMax = height[l];
                }
                else
                {
                    result += lMax - height[l];
                }
                l++;
            }
            else
            {
                if (height[r] > rMax)
                {
                    rMax = height[r];
                }
                else
                {
                    result += rMax - height[r];
                }
                r--;
            }
        }
        return result;
    }
}
// @lc code=end

