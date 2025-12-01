/*
 * @lc app=leetcode id=2169 lang=csharp
 *
 * [2169] Count Operations to Obtain Zero
 */

// @lc code=start
public class Solution {
    public int CountOperations(int num1, int num2) {
        int result = 0;
        while (num1 > 0 && num2 > 0)
        {
            result += num1 / num2;
            num1 %= num2;
            num1 ^= num2;
            num2 ^= num1;
            num1 ^= num2;
        }

        return result;
    }
}
// @lc code=end

