/*
 * @lc app=leetcode id=3516 lang=csharp
 *
 * [3516] Find Cloest Person
 */

// @lc code=start
public class Solution {
    public int FindClosest(int x, int y, int z) {
        x = Math.Abs(x - z);
        y = Math.Abs(y - z);
        if (x == y)
        {
            return 0;
        }
        else if (x < y)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}
// @lc code=end

