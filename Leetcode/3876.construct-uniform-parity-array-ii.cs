/*
 * @lc app=leetcode id=3876 lang=csharp
 *
 * [3876] Construct Uniform Parity Array II
 */

// @lc code=start
public class Solution {
    public bool UniformArray(int[] nums1) {
        int min = int.MaxValue;
        bool hasOdd = false;

        foreach (int num in nums1)
        {
            min = Math.Min(min, num);
            if ((num & 1) == 1)
            {
                hasOdd = true;
            }
        }

        if ((min & 1) == 1)
        {
            return true;
        }

        return !hasOdd;
    }
}
// @lc code=end

