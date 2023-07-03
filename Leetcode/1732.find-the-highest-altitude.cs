/*
 * @lc app=leetcode id=1732 lang=csharp
 *
 * [1732] Find the Highest Altitude
 */

// @lc code=start
public class Solution {
    public int LargestAltitude(int[] gain) {
         int highest = 0,
            current = 0;

        for (int i = 0; i < gain.Length; i++)
        {
            current += gain[i];
            highest = Math.Max(highest, current);
        }

        return highest;
    }
}
// @lc code=end

