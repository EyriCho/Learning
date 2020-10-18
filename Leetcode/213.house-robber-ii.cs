/*
 * @lc app=leetcode id=213 lang=csharp
 *
 * [213] House Robber II
 */

// @lc code=start
public class Solution {
    public int Rob(int[] nums) {
        if (nums.Length == 1)
            return nums[0];
        
        // run dp twice,
        // first time without the last number
        // second time without the first number

        // first time;
        int a = 0, b = 0;
        int max = 0;
        int p = nums.Length - 1;
        
        for (int i = 0; i < nums.Length - 1; i++)
        {
            if (a + nums[i] > b)
                max = a + nums[i];
            else
                max = b;
            a = b;
            b = max;
        }
        
        var result = a > b ? a : b;
        
        // second time;
        a = 0;
        b = 0;
        max = 0;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (a + nums[i] > b)
                max = a + nums[i];
            else
                max = b;
            a = b;
            b = max;
        }
        max = a > b ? a : b;
        
        return result > max ? result : max;
    }
}
// @lc code=end

