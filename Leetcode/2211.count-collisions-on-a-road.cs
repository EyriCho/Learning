/*
 * @lc app=leetcode id=2211 lang=csharp
 *
 * [2211] Count Collisions on a Road
 */

// @lc code=start
public class Solution {
    public int CountCollisions(string directions) {
        int result = 0,
            l = 0,
            r = directions.Length - 1;

        while (l <= r && directions[l] == 'L')
        {
            l++;
        }

        while (l <= r && directions[r] == 'R')
        {
            r--;
        }

        for (int i = l; i <= r; i++)
        {
            result += directions[i] == 'S' ? 0 : 1;
        }

        return result;
    }
}
// @lc code=end

