/*
 * @lc app=leetcode id=2563 lang=csharp
 *
 * [2563] Count the Number of Fair Pairs 
 */

// @lc code=start
public class Solution {
    public long CountFairPairs(int[] nums, int lower, int upper) {
        Array.Sort(nums);

        long FindPair(int target)
        {
            long rst = 0L;
            int l = 0,
                r = nums.Length - 1,
                sum = 0;

            while (l < r)
            {
                sum = nums[l] + nums[r];
                if (sum <= target)
                {
                    rst += r - l;
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return rst;
        }

        return FindPair(upper) - FindPair(lower - 1);
    }
}
// @lc code=end
