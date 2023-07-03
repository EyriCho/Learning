/*
 * @lc app=leetcode id=1232 lang=csharp
 *
 * [1232] Check If It Is a Straight Line
 */

// @lc code=start
public class Solution {
    public bool CheckStraightLine(int[][] coordinates) {
        int dy = coordinates[1][1] - coordinates[0][1],
            dx = coordinates[1][0] - coordinates[0][0];

        for (int i = 2; i < coordinates.Length; i++)
        {
            int dxi = coordinates[i][0] - coordinates[0][0],
                dyi = coordinates[i][1] - coordinates[0][1];
            
            if (dx * dyi != dy * dxi)
            {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

