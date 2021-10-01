/*
 * @lc app=leetcode id=922 lang=csharp
 *
 * [922] Sort Array By Parity II
 */

// @lc code=start
public class Solution {
    public int[] SortArrayByParityII(int[] nums) {
        int even = 0, odd = 1;
        
        while (even < nums.Length)
        {
            while (even < nums.Length && nums[even] % 2 == 0)
                even += 2;
            if (even >= nums.Length)
                break;
            while (odd < nums.Length && nums[odd] % 2 == 1)
                odd += 2;
            
            nums[even] ^= nums[odd];
            nums[odd] ^= nums[even];
            nums[even] ^= nums[odd];
        }
        
        return nums;
    }
}
// @lc code=end

