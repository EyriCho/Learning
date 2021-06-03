/*
 * @lc app=leetcode id=453 lang=csharp
 *
 * [453] Minimum Moves to Equal Array Elements
 */

// @lc code=start
public class Solution {
    public int MinMoves(int[] nums) {
        int min = nums[0],
            total = 0;
        foreach (var num in nums)
        {
            min = Math.Min(min, num);
            total += num;
        }
        
        return total - min * nums.Length;
    }
}
// @lc code=end

