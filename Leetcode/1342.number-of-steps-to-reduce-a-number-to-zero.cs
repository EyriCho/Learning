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
            if ((num & 1) > 0)
                num--;
            else
                num >>= 1;
            
            result++;
        }
        
        return result;
    }
}
// @lc code=end

