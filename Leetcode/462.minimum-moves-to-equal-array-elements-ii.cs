/*
 * @lc app=leetcode id=462 lang=csharp
 *
 * [462] Minimum Moves to Equal Array Elements II
 */

// @lc code=start
public class Solution {
    public int MinMoves2(int[] nums) {
        Array.Sort(nums);
        var mid = (nums.Length - 1) / 2;
        
        int result = 0;
        foreach (var num in nums)
            result += Math.Abs(num - nums[mid]);
        
        return result;
    }
}
// @lc code=end

