/*
 * @lc app=leetcode id=1465 lang=csharp
 *
 * [1465] Maximum Area of a Piece of Cake After Horizontal and Vertical Cuts
 */

// @lc code=start
public class Solution {
    public int MaxArea(int h, int w, int[] horizontalCuts, int[] verticalCuts) {
        int x = 0, y = 0;
        int maxHeight = 0, maxWidth = 0;
        Array.Sort(horizontalCuts);
        Array.Sort(verticalCuts);
        
        foreach (var cut in horizontalCuts)
        {
            maxHeight = Math.Max(maxHeight, cut - x);
            x = cut;
        }
        maxHeight = Math.Max(maxHeight, h - x);
        
        foreach (var cut in verticalCuts)
        {
            maxWidth = Math.Max(maxWidth, cut - y);
            y = cut;
        }
        maxWidth = Math.Max(maxWidth, w - y);
        
        return (int)((long)maxHeight * maxWidth % 1_000_000_007);
    }
}
// @lc code=end

