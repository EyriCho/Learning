/*
 * @lc app=leetcode id=223 lang=csharp
 *
 * [223] Rectangle Area
 */

// @lc code=start
public class Solution {
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2) {
        int width = 0, height = 0;
        
        if (bx1 <= ax1 && ax1 <= bx2)
        {
            width = Math.Min(ax2, bx2) - ax1;
        }
        else if (ax1 <= bx1 && bx1 <= ax2)
        {
            width = Math.Min(ax2, bx2) - bx1;
        }
        
        if (by1 <= ay1 && ay1 <= by2)
        {
            height = Math.Min(ay2, by2) - ay1;
        }
        else if (ay1 <= by1 && by1 <= ay2)
        {
            height = Math.Min(ay2, by2) - by1;
        }
        
        return (ax2 - ax1) * (ay2 - ay1) +
            (bx2 - bx1) * (by2 - by1) -
            width * height;
    }
}
// @lc code=end

