/*
 * @lc app=leetcode id=3622 lang=csharp
 *
 * [3622] Check Divisibility by Digit Sum and Product
 */

// @lc code=start
public class Solution {
    public bool CheckDivisibility(int n) {
        int num = n,
            sum = 0,
            mul = 1;
        
        while (num > 0)
        {
            sum += num % 10;
            mul *= num % 10;
            num /= 10;
        }

        return n % (sum + mul) == 0;
    }
}
// @lc code=end

