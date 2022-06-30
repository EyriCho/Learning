/*
 * @lc app=leetcode id=1342 lang=csharp
 *
 * [1342] Number of Steps to Reduce a Number to Zero
 */

// @lc code=start
public class Solution {
    public int NumberOfSteps (int num) {
        int result = 0;

        while (num > 0)
        {            
            result++;
            num = num % 2 == 0 ? num >> 1 : num - 1;
        }
        
        return result;
    }
}
// @lc code=end

