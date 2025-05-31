/*
 * @lc app=leetcode id=1550 lang=csharp
 *
 * [1550] Three Consecutive Odds
 */

// @lc code=start
public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        int count = 0;
        foreach (int num in arr)
        {
            if ((num & 1) == 0)
            {
                count = 0;
            }
            else if (++count == 3)
            {
                return true;
            }
        }

        return false;
    }
}
// @lc code=end

