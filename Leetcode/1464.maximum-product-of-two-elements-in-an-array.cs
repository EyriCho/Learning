/*
 * @lc app=leetcode id=1464 lang=csharp
 *
 * [1464] Maximum Product of Two Elements in an Array
 */

// @lc code=start
public class Solution {
    public int MaxProduct(int[] nums) {
        int first = -1,
            second = -1;
        
        foreach (int num in nums)
        {
            if (num > first)
            {
                second = first;
                first = num;
            }
            else if (num > second)
            {
                second = num;
            }
        }

        return (first - 1) * (second - 1);
    }
}
// @lc code=end

