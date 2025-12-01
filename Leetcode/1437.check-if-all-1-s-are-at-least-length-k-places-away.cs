/*
 * @lc app=leetcode id=1437 lang=csharp
 *
 * [1437] Check If All 1's Are at Least Length K Places Away
 */

// @lc code=start
public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        int dist = k;
        foreach (int num in nums)
        {
            if (num == 0)
            {
                dist++;
                continue;
            }

            if (dist < k)
            {
                return false;
            }

            dist = 0;
        }

        return true;
    }
}
// @lc code=end

