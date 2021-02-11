/*
 * @lc app=leetcode id=1437 lang=csharp
 *
 * [1437] Check If All 1's Are at Least Length K Places Away
 */

// @lc code=start
public class Solution {
    public bool KLengthApart(int[] nums, int k) {
        if (k == 0)
            return true;

        int last = -k - 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                if (i - last <= k)
                    return false;
                last = i;
            }
        }
        return true;
    }
}
// @lc code=end

