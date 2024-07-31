/*
 * @lc app=leetcode id=1550 lang=csharp
 *
 * [1550] Three Consecutive Odds
 */

// @lc code=start
public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        bool first = false,
            second = false;
        foreach (int num in arr)
        {
            if ((num & 1) > 0)
            {
                if (second)
                {
                    return true;
                }
                else if (first)
                {
                    second = true;
                }
                else
                {
                    first = true;
                }
            }
            else
            {
                first = second = false;
            }
        }

        return false;
    }
}
// @lc code=end

