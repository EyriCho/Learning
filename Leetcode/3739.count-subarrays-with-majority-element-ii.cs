/*
 * @lc app=leetcode id=3739 lang=csharp
 *
 * [3739] Count Subarrays With Majority Element II
 */

// @lc code=start
public class Solution {
    public long CountMajoritySubarrays(int[] nums, int target) {
        int[] pre = new int[nums.Length * 2 + 1];
        pre[nums.Length] = 1;
        int count = nums.Length;
        long result = 0L,
            preSum = 0;
        
        foreach (int num in nums)
        {
            if (num == target)
            {
                preSum += pre[count];
                count++;
                pre[count]++;
            }
            else
            {
                count--;
                preSum -= pre[count];
                pre[count]++;
            }

            result += preSum;
        }

        return result;
    }
}
// @lc code=end

