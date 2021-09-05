/*
 * @lc app=leetcode id=598 lang=csharp
 *
 * [598] Range Addition II
 */

// @lc code=start
public class Solution {
    public int MaxCount(int m, int n, int[][] ops) {
        int xMin = m, yMin = n;
        
        foreach (var op in ops)
        {
            xMin = Math.Min(xMin, op[0]);
            yMin = Math.Min(yMin, op[1]);
        }
        
        return xMin * yMin;
    }
}
// @lc code=end

