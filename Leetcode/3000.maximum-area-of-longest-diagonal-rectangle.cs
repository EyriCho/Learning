/*
 * @lc app=leetcode id=3000 lang=csharp
 *
 * [3000] Maximum Area of Longest Diagonal Rectangle
 */

// @lc code=start
public class Solution {
    public int AreaOfMaxDiagonal(int[][] dimensions) {
        int maxDiagonal = 0,
            maxArea = 0,
            diagonal = 0,
            area = 0;
        
        foreach (int[] dimension in dimensions)
        {
            diagonal = dimension[0] * dimension[0] + dimension[1] * dimension[1];
            if (diagonal > maxDiagonal)
            {
                maxDiagonal = diagonal;
                maxArea = dimension[0] * dimension[1];
            }
            else if (diagonal == maxDiagonal)
            {
                maxArea = Math.Max(maxArea, dimension[0] * dimension[1]);
            }
        }

        return maxArea;
    }
}
// @lc code=end

