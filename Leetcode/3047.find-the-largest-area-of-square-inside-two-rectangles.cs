/*
 * @lc app=leetcode id=3047 lang=csharp
 *
 * [3047] Find the Largest Area of Square Inside Two Rectangles
 */

// @lc code=start
public class Solution {
    public long LargestSquareArea(int[][] bottomLeft, int[][] topRight) {
        int width = 0, height = 0,
            maxSide = 0;
        
        for (int i = 0; i < bottomLeft.Length; i++)
        {
            for (int j = i + 1; j < bottomLeft.Length; j++)
            {
                width = int.Min(topRight[i][0], topRight[j][0]) - 
                    int.Max(bottomLeft[i][0], bottomLeft[j][0]);
                height = int.Min(topRight[i][1], topRight[j][1]) - 
                    int.Max(bottomLeft[i][1], bottomLeft[j][1]);

                maxSide = Math.Max(maxSide, int.Min(width, height));
            }
        }

        return (long)maxSide * maxSide;
    }
}
// @lc code=end

