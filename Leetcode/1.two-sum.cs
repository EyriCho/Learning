/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new ();
        int left = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            left = target - nums[i];
            if (dict.ContainsKey(left))
            {
                return new int[] {i, dict[left]};
            }
            else if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }
        return new int[] {0, 1};
    }
}
// @lc code=end

