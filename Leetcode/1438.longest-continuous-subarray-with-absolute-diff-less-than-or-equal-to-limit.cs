/*
 * @lc app=leetcode id=1438 lang=csharp
 *
 * [1438] Longest Continuous Subarray With Absolute Diff Less Than or Equal to Limit
 */

// @lc code=start
public class Solution {
    public int LongestSubarray(int[] nums, int limit) {
        int result = 0,
            l = 0,
            r = 0;

        LinkedList<int> max = new (),
            min = new();

        for (; r < nums.Length; r++)
        {
            while (max.Count > 0 && nums[r] >= nums[max.Last()])
            {
                max.RemoveLast();
            }
            while (min.Count > 0 && nums[r] <= nums[min.Last()])
            {
                min.RemoveLast();
            }
            max.AddLast(r);
            min.AddLast(r);

            while (Math.Abs(nums[max.First()] - nums[min.First()]) > limit)
            {
                l++;
                while (max.First() < l)
                {
                    max.RemoveFirst();
                }
                while (min.First() < l)
                {
                    min.RemoveFirst();
                }
            }

            result = Math.Max(r - l + 1, result);
        }
        
        return result;
    }
}
// @lc code=end

