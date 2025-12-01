/*
 * @lc app=leetcode id=1018 lang=csharp
 *
 * [1018] Binary Prefix Divisible By 5
 */

// @lc code=start
public class Solution {
    public IList<bool> PrefixesDivBy5(int[] nums) {
        List<bool> result = new (nums.Length);
        
        int num = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            num = ((num << 1) | nums[i]) % 5;
            result.Add(num == 0);
        }

        return result;
    }
}
// @lc code=end

