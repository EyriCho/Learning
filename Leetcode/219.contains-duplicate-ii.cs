/*
 * @lc app=leetcode id=219 lang=csharp
 *
 * [219] Contains Duplicate II
 */

// @lc code=start
public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        var dict = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.TryGetValue(nums[i], out int j) && i - j <= k)
            {
                return true;
            }
            else
            {
                dict[nums[i]] = i;
            }
        }
        
        return false;
    }
}
// @lc code=end

