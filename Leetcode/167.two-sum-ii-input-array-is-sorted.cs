/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0, r = numbers.Length - 1,
            sum = 0;
        
        while (l < r)
        {
            sum = numbers[l] + numbers[r];
            if (sum > target)
            {
                r--;
            }
            else if (sum < target)
            {
                l++;
            }
            else
            {
                return new int[] { l + 1, r + 1 };
            }
        }
        
        return new int[2];    }
}
// @lc code=end

